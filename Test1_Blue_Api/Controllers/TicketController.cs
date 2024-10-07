using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TicketController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ticket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
        {
            var tickets = await _context.Tickets
                .Where(t => !t.IsDeleted) // Exclude soft deleted tickets
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<TicketDto>>(tickets));
        }

        // GET: api/ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> GetTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null || ticket.IsDeleted)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TicketDto>(ticket));
        }

        // POST: api/ticket
        [HttpPost]
        public async Task<ActionResult<TicketDto>> PostTicket(TicketDto ticketDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ticket = _mapper.Map<Ticket>(ticketDto);
            ticket.CreationDate = DateTime.Now;
            ticket.ModifiedDate = DateTime.Now;

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = ticket.Id }, _mapper.Map<TicketDto>(ticket));
        }

        // PUT: api/ticket/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, TicketDto ticketDto)
        {
            if (id != ticketDto.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null || ticket.IsDeleted)
            {
                return NotFound();
            }

            // Map updated properties
            _mapper.Map(ticketDto, ticket);
            ticket.ModifiedDate = DateTime.Now;

            _context.Entry(ticket).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/ticket/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteTicket([FromRoute] int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null || ticket.IsDeleted)
            {
                return NotFound();
            }

            // Update soft delete properties
            ticket.IsDeleted = true;
            ticket.DeleteAt = DateTime.Now; // Set the deletion timestamp
            ticket.UpdateAt = DateTime.Now;  // Update timestamp for soft delete

            _context.Entry(ticket).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // PATCH: api/ticket/{id}/restore
        [HttpPatch("{id}/restore")]
        //[Authorize(Roles = "Admin")] // Uncomment if authorization is needed
        public async Task<IActionResult> RestoreTicket([FromRoute] int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null || !ticket.IsDeleted)
            {
                return NotFound();
            }

            // Restore properties
            ticket.IsDeleted = false; // Mark as not deleted
            ticket.DeleteAt = null;   // Clear the deletion timestamp
            ticket.UpdateAt = DateTime.Now; // Update timestamp for restoration

            _context.Entry(ticket).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // DELETE: api/ticket/5 (You may want to remove this if not needed)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null || ticket.IsDeleted)
            {
                return NotFound();
            }

            // Soft delete (if you wish to keep this method)
            ticket.IsDeleted = true;
            ticket.DeleteAt = DateTime.Now; // Assuming you have a DeleteAt property in SoftDeleteCommen

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

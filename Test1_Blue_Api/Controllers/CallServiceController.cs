using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class CallServiceController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CallServiceController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CallServiceDto>>> GetCallServices()
        {
            var callServices = await _context.CallServices
                .Include(cs => cs.CallAbout) // Include CallAbout to check its status
                .ThenInclude(ca => ca.CallType) // Include CallType to check its status
                .Where(cs => cs.IsActive && cs.CallAbout.IsActive && cs.CallAbout.CallType.IsActive) // Only get active CallServices and their related active CallAbouts and CallTypes
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<CallServiceDto>>(callServices));
        }

        [HttpPost]
        public async Task<ActionResult<CallServiceDto>> CreateCallService(CallServiceDto callServiceDto)
        {
            var callService = _mapper.Map<CallService>(callServiceDto);
            await _context.CallServices.AddAsync(callService);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCallServices), new { id = callService.Id }, _mapper.Map<CallServiceDto>(callService));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCallService(int id, CallServiceDto callServiceDto)
        {
            if (id != callServiceDto.Id) return BadRequest();

            var callService = await _context.CallServices.FindAsync(id);
            if (callService == null) return NotFound();

            _mapper.Map(callServiceDto, callService);
            _context.Entry(callService).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // [HttpDelete("{id}")]
        //// [Authorize(Roles = "Admin")]
        // public async Task<IActionResult> DeleteCallService(int id)
        // {
        //     var callService = await _context.CallServices.FindAsync(id);
        //     if (callService == null) return NotFound();

        //     _context.CallServices.Remove(callService);
        //     await _context.SaveChangesAsync();
        //     return NoContent();
        // }


        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteCallService(int id)
        {
            var callService = await _context.CallServices.FindAsync(id);
            if (callService == null) return NotFound();

            // Set soft delete properties
            callService.IsDeleted = true;
            callService.DeleteAt = DateTime.UtcNow;
            callService.IsActive = false; // Optional, based on your logic

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreCallService(int id)
        {
            var callService = await _context.CallServices
                .FirstOrDefaultAsync(cs => cs.Id == id && cs.IsDeleted);
            if (callService == null) return NotFound();

            // Restore properties
            callService.IsDeleted = false;
            callService.DeleteAt = null;
            callService.IsActive = true; // Optional, based on your logic
            callService.UpdateAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("callabout/{callAboutId}")]
        public async Task<ActionResult<IEnumerable<CallServiceDto>>> GetCallServicesByCallAboutId(int callAboutId)
        {
            var callServices = await _context.CallServices
                .Where(cs => cs.CallAboutId == callAboutId && cs.IsActive && !cs.IsDeleted)
                .ToListAsync();

            if (callServices.Count == 0)
            {
                return NotFound("No call services found for the specified Call About ID.");
            }

            return Ok(_mapper.Map<IEnumerable<CallServiceDto>>(callServices));
        }



    }
}

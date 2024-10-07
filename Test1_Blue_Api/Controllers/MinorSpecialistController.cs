using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinorSpecialistController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MinorSpecialistController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/minorspecialist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MinorSpecialistDto>>> GetMinorSpecialists()
        {
            var specialists = await _context.MinorSpecialists
                .Where(s => !s.IsDeleted) // Ensure we only get non-deleted specialists
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<MinorSpecialistDto>>(specialists));
        }

        // GET: api/minorspecialist/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<MinorSpecialistDto>> GetMinorSpecialistById(int id)
        {
            var specialist = await _context.MinorSpecialists
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);

            if (specialist == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MinorSpecialistDto>(specialist));
        }

        // POST: api/minorspecialist
        [HttpPost]
        public async Task<ActionResult<MinorSpecialistDto>> AddMinorSpecialist(MinorSpecialistDto specialistDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var specialist = _mapper.Map<MinorSpecialist>(specialistDto);
            await _context.MinorSpecialists.AddAsync(specialist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMinorSpecialistById), new { id = specialist.Id }, _mapper.Map<MinorSpecialistDto>(specialist));
        }

        // PUT: api/minorspecialist/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMinorSpecialist(int id, MinorSpecialistDto specialistDto)
        {
            if (id != specialistDto.Id)
            {
                return BadRequest("ID mismatch.");
            }

            var specialist = await _context.MinorSpecialists
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);

            if (specialist == null)
            {
                return NotFound();
            }

            _mapper.Map(specialistDto, specialist); // Map the updated values to the existing entity

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.MinorSpecialists.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/minorspecialist/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteMinorSpecialist(int id)
        {
            var specialist = await _context.MinorSpecialists.FindAsync(id);
            if (specialist == null || specialist.IsDeleted)
            {
                return NotFound();
            }

            specialist.IsDeleted = true;
            specialist.DeleteAt = DateTime.UtcNow; // Use UTC for consistency
            specialist.UpdateAt = DateTime.UtcNow;

            _context.Entry(specialist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/minorspecialist/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreMinorSpecialist(int id)
        {
            var specialist = await _context.MinorSpecialists.FindAsync(id);
            if (specialist == null || !specialist.IsDeleted)
            {
                return NotFound();
            }

            specialist.IsDeleted = false;
            specialist.DeleteAt = null;
            specialist.UpdateAt = DateTime.UtcNow;

            _context.Entry(specialist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/minorspecialist/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMinorSpecialist(int id)
        {
            var specialist = await _context.MinorSpecialists.FindAsync(id);
            if (specialist == null)
            {
                return NotFound();
            }

            _context.MinorSpecialists.Remove(specialist);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

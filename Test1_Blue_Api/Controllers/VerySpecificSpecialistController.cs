using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerySpecificSpecialistController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public VerySpecificSpecialistController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/veryspecificspecialist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VerySpecificSpecialistDto>>> GetVerySpecificSpecialists()
        {
            var specialists = await _context.VerySpecificSpecialists
                                             .Where(s => !s.IsDeleted) // Only get non-deleted specialists
                                             .ToListAsync();
            return Ok(_mapper.Map<IEnumerable<VerySpecificSpecialistDto>>(specialists));
        }

        // GET: api/veryspecificspecialist/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<VerySpecificSpecialistDto>> GetVerySpecificSpecialistById(int id)
        {
            var specialist = await _context.VerySpecificSpecialists
                                            .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted); // Check for IsDeleted
            if (specialist == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VerySpecificSpecialistDto>(specialist));
        }

        // POST: api/veryspecificspecialist
        [HttpPost]
        public async Task<ActionResult<VerySpecificSpecialistDto>> AddVerySpecificSpecialist(VerySpecificSpecialistDto specialistDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var specialist = _mapper.Map<VerySpecificSpecialist>(specialistDto);
            _context.VerySpecificSpecialists.Add(specialist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVerySpecificSpecialistById), new { id = specialist.Id }, _mapper.Map<VerySpecificSpecialistDto>(specialist));
        }

        // PUT: api/veryspecificspecialist/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVerySpecificSpecialist(int id, VerySpecificSpecialistDto specialistDto)
        {
            if (id != specialistDto.Id)
            {
                return BadRequest();
            }

            var specialist = _mapper.Map<VerySpecificSpecialist>(specialistDto);
            _context.Entry(specialist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.VerySpecificSpecialists.AnyAsync(e => e.Id == id && !e.IsDeleted))
                {
                    return NotFound();
                }
                throw; // Re-throw if a different error occurred
            }

            return NoContent();
        }

        // PATCH: api/veryspecificspecialist/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteVerySpecificSpecialist(int id)
        {
            var specialist = await _context.VerySpecificSpecialists.FindAsync(id);
            if (specialist == null || specialist.IsDeleted)
            {
                return NotFound();
            }

            specialist.IsDeleted = true;
            specialist.DeleteAt = DateTime.Now;
            specialist.UpdateAt = DateTime.Now;

            _context.Entry(specialist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/veryspecificspecialist/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreVerySpecificSpecialist(int id)
        {
            var specialist = await _context.VerySpecificSpecialists.FindAsync(id);
            if (specialist == null || !specialist.IsDeleted)
            {
                return NotFound();
            }

            specialist.IsDeleted = false;
            specialist.DeleteAt = null;
            specialist.UpdateAt = DateTime.Now;

            _context.Entry(specialist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/veryspecificspecialist/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVerySpecificSpecialist(int id)
        {
            var specialist = await _context.VerySpecificSpecialists.FindAsync(id);
            if (specialist == null)
            {
                return NotFound();
            }

            _context.VerySpecificSpecialists.Remove(specialist);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

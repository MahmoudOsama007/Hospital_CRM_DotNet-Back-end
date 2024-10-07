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
    public class MajorSpecialistController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MajorSpecialistController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/majorspecialist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MajorSpecialistDto>>> GetMajorSpecialists()
        {
            var specialists = await _context.MajorSpecialists.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<MajorSpecialistDto>>(specialists));
        }

        // GET: api/majorspecialist/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<MajorSpecialistDto>> GetMajorSpecialistById(int id)
        {
            var specialist = await _context.MajorSpecialists.FindAsync(id);
            if (specialist == null || specialist.IsDeleted)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MajorSpecialistDto>(specialist));
        }

        // POST: api/majorspecialist
        [HttpPost]
        public async Task<ActionResult<MajorSpecialistDto>> AddMajorSpecialist(MajorSpecialistDto specialistDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var specialist = _mapper.Map<MajorSpecialist>(specialistDto);
            _context.MajorSpecialists.Add(specialist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMajorSpecialistById), new { id = specialist.Id }, _mapper.Map<MajorSpecialistDto>(specialist));
        }

        // PUT: api/majorspecialist/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMajorSpecialist(int id, MajorSpecialistDto specialistDto)
        {
            if (id != specialistDto.Id)
            {
                return BadRequest();
            }

            var specialist = _mapper.Map<MajorSpecialist>(specialistDto);
            _context.Entry(specialist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.MajorSpecialists.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/majorspecialist/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteMajorSpecialist(int id)
        {
            var specialist = await _context.MajorSpecialists.FindAsync(id);
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

        // PATCH: api/majorspecialist/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreMajorSpecialist(int id)
        {
            var specialist = await _context.MajorSpecialists.FindAsync(id);
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

        // DELETE: api/majorspecialist/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMajorSpecialist(int id)
        {
            var specialist = await _context.MajorSpecialists.FindAsync(id);
            if (specialist == null)
            {
                return NotFound();
            }

            _context.MajorSpecialists.Remove(specialist);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // GET: api/majorspecialist/hospital/{hospitalId}
        [HttpGet("hospital/{hospitalId}")]
        public async Task<ActionResult<IEnumerable<MajorSpecialistDto>>> GetMajorSpecialistsByHospitalId(int hospitalId)
        {
            var specialists = await _context.MajorSpecialists
                .Where(s => s.HospitalId == hospitalId && !s.IsDeleted) // Assuming there's a HospitalId property in MajorSpecialist
                .ToListAsync();

            if (specialists == null || specialists.Count == 0)
            {
                return NotFound(); // Or return an empty list if that is preferred
            }

            return Ok(_mapper.Map<IEnumerable<MajorSpecialistDto>>(specialists));
        }


    }
}

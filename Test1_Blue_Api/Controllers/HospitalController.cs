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
    public class HospitalController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public HospitalController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalDto>>> GetHospitals()
        {
            var hospitals = await _context.Hospitals.Where(h => !h.IsDeleted).ToListAsync();
            return Ok(_mapper.Map<IEnumerable<HospitalDto>>(hospitals));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalDto>> GetHospitalById(int id)
        {
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null || hospital.IsDeleted)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<HospitalDto>(hospital));
        }

        [HttpPost]
        public async Task<ActionResult<HospitalDto>> AddHospital(HospitalDto hospitalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hospital = _mapper.Map<Hospital>(hospitalDto);
            _context.Hospitals.Add(hospital);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHospitalById), new { id = hospital.Id }, _mapper.Map<HospitalDto>(hospital));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, HospitalDto hospitalDto)
        {
            // Validate the ID in the route matches the ID in the DTO
            if (id != hospitalDto.Id)
            {
                return BadRequest("Hospital ID mismatch.");
            }

            // Find the existing hospital
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null || hospital.IsDeleted)
            {
                return NotFound($"Hospital with ID {id} not found or has been deleted.");
            }

            // Use AutoMapper to map the properties from hospitalDto to hospital
            _mapper.Map(hospitalDto, hospital);
            hospital.UpdateAt = DateTime.UtcNow; // Update the timestamp

            _context.Entry(hospital).State = EntityState.Modified; // Mark the entity as modified

            try
            {
                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Hospitals.Any(e => e.Id == id))
                {
                    return NotFound($"Hospital with ID {id} not found during update.");
                }
                throw; // Rethrow the exception if not found
            }
            catch (DbUpdateException ex)
            {
                // Log the exception (optional, if you have logging configured)
                // _logger.LogError(ex, "Error updating hospital with ID {Id}", id);
                return StatusCode(500, "An error occurred while updating the hospital. Please try again.");
            }

            return NoContent(); // Return 204 No Content on success
        }


        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteHospital(int id)
        {
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null || hospital.IsDeleted)
            {
                return NotFound();
            }

            hospital.IsDeleted = true;
            hospital.DeleteAt = DateTime.UtcNow;
            hospital.UpdateAt = DateTime.UtcNow;

            _context.Entry(hospital).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreHospital(int id)
        {
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null || !hospital.IsDeleted)
            {
                return NotFound();
            }

            hospital.IsDeleted = false;
            hospital.DeleteAt = null;
            hospital.UpdateAt = DateTime.UtcNow;

            _context.Entry(hospital).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null || hospital.IsDeleted)
            {
                return NotFound();
            }

            _context.Hospitals.Remove(hospital);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

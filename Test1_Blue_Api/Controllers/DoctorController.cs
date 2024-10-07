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
    public class DoctorController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DoctorController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/doctor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDto>>> GetDoctors()
        {
            var doctors = await _context.Doctors.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<DoctorDto>>(doctors));
        }

        // GET: api/doctor/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<DoctorDto>> GetDoctorById(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null || doctor.IsDeleted)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DoctorDto>(doctor));
        }

        // POST: api/doctor
        [HttpPost]
        public async Task<ActionResult<DoctorDto>> AddDoctor(DoctorDto doctorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctor = _mapper.Map<Doctor>(doctorDto);
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDoctorById), new { id = doctor.Id }, _mapper.Map<DoctorDto>(doctor));
        }

        // PUT: api/doctor/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctor(int id, DoctorDto doctorDto)
        {
            if (id != doctorDto.Id)
            {
                return BadRequest();
            }

            var doctor = _mapper.Map<Doctor>(doctorDto);
            _context.Entry(doctor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Doctors.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/doctor/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null || doctor.IsDeleted)
            {
                return NotFound();
            }

            doctor.IsDeleted = true;
            doctor.DeleteAt = DateTime.Now;
            doctor.UpdateAt = DateTime.Now;

            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/doctor/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null || !doctor.IsDeleted)
            {
                return NotFound();
            }

            doctor.IsDeleted = false;
            doctor.DeleteAt = null;
            doctor.UpdateAt = DateTime.Now;

            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/doctor/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Azure;
using Microsoft.AspNetCore.JsonPatch;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CityController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CityController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/city
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetCities()
        {
            var cities = await _context.Cities.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<CityDto>>(cities));
        }

        // GET: api/city/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CityDto>> GetCityById(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CityDto>(city));
        }

        // POST: api/city
        [HttpPost]
        public async Task<ActionResult<CityDto>> AddCity(CityDto cityDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = _mapper.Map<City>(cityDto);
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCityById), new { id = city.Id }, _mapper.Map<CityDto>(city));
        }

        // PUT: api/city/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, CityDto cityDto)
        {
            if (id != cityDto.Id)
            {
                return BadRequest();
            }

            var city = _mapper.Map<City>(cityDto);
            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Cities.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/city/{id}
        // PATCH: api/city/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteCity([FromRoute] int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null || city.IsDeleted)
            {
                return NotFound();
            }

            // Update soft delete properties
            city.IsDeleted = true;
            city.DeleteAt = DateTime.Now; // Set the deletion timestamp
            city.UpdateAt = DateTime.Now;  // Update timestamp for soft delete

            _context.Entry(city).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // PATCH: api/city/{id}/restore
        [HttpPatch("{id}/restore")]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RestoreCity([FromRoute] int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null || !city.IsDeleted)
            {
                return NotFound();
            }

            // Restore properties
            city.IsDeleted = false; // Mark as not deleted
            city.DeleteAt = null;   // Clear the deletion timestamp
            city.UpdateAt = DateTime.Now; // Update timestamp for restoration

            _context.Entry(city).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }









        // DELETE: api/city/{id}
        [HttpDelete("{id}")]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

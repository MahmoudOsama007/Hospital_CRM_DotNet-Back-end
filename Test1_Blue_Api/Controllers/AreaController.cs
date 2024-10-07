using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AreaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AreaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/area
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaDto>>> GetAreas()
        {
            var areas = await _context.Areas.Include(a => a.City).ToListAsync();
            return Ok(_mapper.Map<IEnumerable<AreaDto>>(areas));
        }

        // GET: api/area/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaDto>> GetAreaById(int id)
        {
            var area = await _context.Areas.Include(a => a.City).FirstOrDefaultAsync(a => a.Id == id);
            if (area == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<AreaDto>(area));
        }

        // POST: api/area
        [HttpPost]
        public async Task<ActionResult<AreaDto>> AddArea(AreaDto areaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var area = _mapper.Map<Area>(areaDto);
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAreaById), new { id = area.Id }, _mapper.Map<AreaDto>(area));
        }

        // PUT: api/area/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArea(int id, AreaDto areaDto)
        {
            if (id != areaDto.Id)
            {
                return BadRequest();
            }

            var area = _mapper.Map<Area>(areaDto);
            _context.Entry(area).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Areas.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }



        // PATCH: api/area/{id}
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteArea([FromRoute] int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area == null || area.IsDeleted)
            {
                return NotFound();
            }

            // Update soft delete properties
            area.IsDeleted = true;
            area.DeleteAt = DateTime.Now; // Set the deletion timestamp
            area.UpdateAt = DateTime.Now;  // Update timestamp for soft delete

            _context.Entry(area).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // PATCH: api/area/{id}/restore
        [HttpPatch("{id}/restore")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> RestoreArea([FromRoute] int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area == null || !area.IsDeleted)
            {
                return NotFound();
            }

            // Restore properties
            area.IsDeleted = false; // Mark as not deleted
            area.DeleteAt = null;   // Clear the deletion timestamp
            area.UpdateAt = DateTime.Now; // Update timestamp for restoration

            _context.Entry(area).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }





        // DELETE: api/area/{id}
        [HttpDelete("{id}")]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area == null)
            {
                return NotFound();
            }

            _context.Areas.Remove(area);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

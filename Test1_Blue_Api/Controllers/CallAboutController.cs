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
    public class CallAboutController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CallAboutController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CallAboutDto>>> GetCallAbouts()
        {
            var callAbouts = await _context.CallAbouts
                .Include(ca => ca.CallType) // Include CallType to check its status
                .Where(ca => ca.IsActive && ca.CallType.IsActive) // Only get active CallAbouts and their active CallTypes
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<CallAboutDto>>(callAbouts));
        }

        [HttpPost]
        public async Task<ActionResult<CallAboutDto>> CreateCallAbout(CallAboutDto callAboutDto)
        {
            var callAbout = _mapper.Map<CallAbout>(callAboutDto);
            await _context.CallAbouts.AddAsync(callAbout);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCallAbouts), new { id = callAbout.Id }, _mapper.Map<CallAboutDto>(callAbout));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCallAbout(int id, CallAboutDto callAboutDto)
        {
            if (id != callAboutDto.Id) return BadRequest();

            var callAbout = await _context.CallAbouts.FindAsync(id);
            if (callAbout == null) return NotFound();

            _mapper.Map(callAboutDto, callAbout);
            _context.Entry(callAbout).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //[HttpDelete("{id}")]
        ////[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> DeleteCallAbout(int id)
        //{
        //    var callAbout = await _context.CallAbouts.FindAsync(id);
        //    if (callAbout == null) return NotFound();

        //    _context.CallAbouts.Remove(callAbout);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}


        [HttpPatch("{id}/softdelete")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> SoftDeleteCallAbout(int id)
        {
            var callAbout = await _context.CallAbouts.FindAsync(id);
            if (callAbout == null) return NotFound();

            // Soft delete logic
            callAbout.IsDeleted = true;
            callAbout.DeleteAt = DateTime.UtcNow;
            //callAbout.IsActive = false;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{id}/restore")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> RestoreCallAbout(int id)
        {
            var callAbout = await _context.CallAbouts.FindAsync(id);
            if (callAbout == null) return NotFound();

            // Restore logic
            callAbout.IsDeleted = false;
            callAbout.DeleteAt = null;
            callAbout.UpdateAt = DateTime.UtcNow;
            //callAbout.IsActive = true;

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

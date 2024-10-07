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
    //[Authorize]
    public class CallTypeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CallTypeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CallTypeDto>>> GetCallTypes()
        {
            var callTypes = await _context.CallTypes
              //  .Where(ct => ct.IsActive && !ct.IsDeleted) // Get only active and not deleted CallTypes
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<CallTypeDto>>(callTypes));
        }

        [HttpPost]
        public async Task<ActionResult<CallTypeDto>> CreateCallType(CallTypeDto callTypeDto)
        {
            var callType = _mapper.Map<CallType>(callTypeDto);
            callType.IsActive = true; // Ensure it's active by default
            callType.IsDeleted = false; // Ensure it's not marked as deleted

            await _context.CallTypes.AddAsync(callType);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCallTypes), new { id = callType.Id }, _mapper.Map<CallTypeDto>(callType));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCallType(int id, CallTypeDto callTypeDto)
        {
            if (id != callTypeDto.Id) return BadRequest();

            var callType = await _context.CallTypes.FindAsync(id);
            if (callType == null || callType.IsDeleted) return NotFound(); // Return not found if deleted

            _mapper.Map(callTypeDto, callType);
            _context.Entry(callType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PATCH: api/calltype/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteCallType([FromRoute] int id)
        {
            var callType = await _context.CallTypes.FindAsync(id);
            if (callType == null || callType.IsDeleted)
            {
                return NotFound();
            }

            // Update soft delete properties
            callType.IsDeleted = true; // Mark as deleted
            callType.DeleteAt = DateTime.Now; // Set the deletion timestamp
            callType.UpdateAt = DateTime.Now;  // Update timestamp for soft delete

            _context.Entry(callType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // PATCH: api/calltype/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreCallType([FromRoute] int id)
        {
            var callType = await _context.CallTypes.FindAsync(id);
            if (callType == null || !callType.IsDeleted)
            {
                return NotFound();
            }

            // Restore soft delete properties
            callType.IsDeleted = false; // Mark as active
            callType.UpdateAt = DateTime.Now;  // Update timestamp for restoration

            _context.Entry(callType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }
    }
}

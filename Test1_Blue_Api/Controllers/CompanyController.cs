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
    public class CompanyController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CompanyController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
        {
            var companies = await _context.Companys.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<CompanyDto>>(companies));
        }

        // GET: api/company/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetCompanyById(int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CompanyDto>(company));
        }

        // POST: api/company
        [HttpPost]
        public async Task<ActionResult<CompanyDto>> AddCompany(CompanyDto companyDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var company = _mapper.Map<Company>(companyDto);
            _context.Companys.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompanyById), new { id = company.Id }, _mapper.Map<CompanyDto>(company));
        }

        // PUT: api/company/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, CompanyDto companyDto)
        {
            if (id != companyDto.Id)
            {
                return BadRequest();
            }

            var company = _mapper.Map<Company>(companyDto);
            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Companys.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }




        // PATCH: api/company/{id}
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteCompany([FromRoute] int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null || company.IsDeleted)
            {
                return NotFound();
            }

            // Update soft delete properties
            company.IsDeleted = true;
            company.DeleteAt = DateTime.Now; // Set the deletion timestamp
            company.UpdateAt = DateTime.Now;  // Update timestamp for soft delete

            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }

        // PATCH: api/company/{id}/restore
        [HttpPatch("{id}/restore")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> RestoreCompany([FromRoute] int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null || !company.IsDeleted)
            {
                return NotFound();
            }

            // Restore properties
            company.IsDeleted = false; // Mark as not deleted
            company.DeleteAt = null;   // Clear the deletion timestamp
            company.UpdateAt = DateTime.Now; // Update timestamp for restoration

            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content
        }





        // DELETE: api/company/{id}
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companys.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

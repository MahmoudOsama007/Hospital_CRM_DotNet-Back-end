using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper; // Inject IMapper

        public CustomerController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            var customers = await _context.Customers
                .Include(c => c.Company)
                .Include(c => c.Area)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<CustomerDto>>(customers)); // Map to DTO
        }


        // GET: api/customer/page/{page}/limit/{limit}

        [HttpGet("page/{page}/limit/{limit}")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers(int page = 1, int limit = 6)
        {
            // Validate parameters
            if (page < 1) page = 1;
            if (limit < 1) limit = 6;

            try
            {
                // Calculate the total count of customers
                var totalCustomers = await _context.Customers.CountAsync();

                // Calculate the total number of pages
                var totalPages = (int)Math.Ceiling((double)totalCustomers / limit);

                // Calculate the customers to skip based on the page and limit
                var customersToSkip = (page - 1) * limit;

                // Fetch the customers for the specified page
                var customers = await _context.Customers
                    .Include(c => c.Company)
                    .Include(c => c.Area)
                    .Skip(customersToSkip)
                    .Take(limit)
                    .ToListAsync();

                // Map to DTO
                var customerDtos = _mapper.Map<IEnumerable<CustomerDto>>(customers);

                // Return the paged result along with total count and total pages
                return Ok(new
                {
                    TotalCount = totalCustomers,
                    TotalPages = totalPages,
                    Page = page,
                    Limit = limit,
                    Customers = customerDtos
                });
            }
            catch (Exception ex)
            {
                // Log the exception (you can use your logging framework here)
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }



        // GET: api/customer/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomerById(int id)
        {
            var customer = await _context.Customers
                .Include(c => c.Company)
                .Include(c => c.Area)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CustomerDto>(customer)); // Map to DTO
        }

        // POST: api/customer
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> AddCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Ensure the AreaId exists
            if (!await _context.Areas.AnyAsync(a => a.Id == customerDto.AreaId))
            {
                return BadRequest("Invalid AreaId.");
            }

            var customer = _mapper.Map<Customer>(customerDto);
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, _mapper.Map<CustomerDto>(customer));
        }


        // PUT: api/customer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, CustomerDto customerDto)
        {
            if (id != customerDto.Id)
            {
                return BadRequest();
            }

            var customer = _mapper.Map<Customer>(customerDto); // Map DTO to entity
            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Customers.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }
        /******************************************************************************************************/
        // PATCH: api/customer/{id}/softdelete
        [HttpPatch("{id}/softdelete")]
        public async Task<IActionResult> SoftDeleteCustomer([FromRoute] int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null || customer.IsDeleted)
            {
                return NotFound();
            }

            customer.IsDeleted = true;
            customer.DeleteAt = DateTime.Now;
            customer.UpdateAt = DateTime.Now;

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }


        // PATCH: api/customer/{id}/restore
        [HttpPatch("{id}/restore")]
        public async Task<IActionResult> RestoreCustomer([FromRoute] int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null || !customer.IsDeleted)
            {
                return NotFound();
            }

            customer.IsDeleted = false;
            customer.DeleteAt = null;
            customer.UpdateAt = DateTime.Now;

            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /*****************************************************************************************************/

        // DELETE: api/customer/{id}
       // [HttpDelete("{id}")]
       //// [Authorize(Roles = "Admin")]
       // public async Task<IActionResult> DeleteCustomer(int id)
       // {
       //     var customer = await _context.Customers.FindAsync(id);
       //     if (customer == null)
       //     {
       //         return NotFound();
       //     }

       //     _context.Customers.Remove(customer);
       //     await _context.SaveChangesAsync();

       //     return NoContent();
       // }
    }
}

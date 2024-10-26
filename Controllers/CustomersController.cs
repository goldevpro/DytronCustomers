using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DytronCustomers.Data;
using DytronCustomers.Models;

namespace DytronCustomers.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerContext _context;

        public CustomersController(CustomerContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GetCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            try
            {
                return await _context.Customers.ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"An error ocurred: {0}", ex });
            }
        }

        [HttpGet("/GetCustomerById")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            } else
            {
                return customer;
            }
        }

        // POST: api/Customers
        /// <summary>
        /// Create a new customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("/AddCustomer")]
        public async Task<IActionResult> PostCustomer([FromBody] Customer customer)
        {
            // Make sure the value for the id will be set automatically by the database
            customer.Id = 0;
            customer.CreatedDate = DateTime.Now;
            customer.LastUpdatedDate = DateTime.Now;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Customer created successfully" });
        }

        // PUT: api/Customers/5
        /// <summary>
        /// Update information for a specific customer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("/UpdateCustomer")]
        public async Task<IActionResult> PutCustomer([FromBody] Customer customer)
        {
            if (!CustomerExists(customer.Id))
            {
                return NotFound();
            }

            customer.LastUpdatedDate = DateTime.Now;
            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, new { message = "An error occurred while updating the customer" });
            }

            return Ok(new { message = "Customer updated successfully" });
        }

        //DELETE: api/Customers/5
        /// <summary>
        /// Delete a specific customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("/DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Customer deleted successfully" });
        }
       
        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}

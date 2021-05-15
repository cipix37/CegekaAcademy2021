using Microsoft.AspNetCore.Mvc;
using MyPersistance.Entities;
using MyPersistance.Repositories;

namespace TemaS2MiercuriV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerRepository CustomerRepository { get; set; }
        public CustomerController(CustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }


        [HttpGet("displayCustomers")]
        public IActionResult DisplayCustomers()
        {
            var customers = CustomerRepository.GetCustomers();
            return Ok(customers);
        }

        [HttpPost("addCustomer")]
        public IActionResult AddCustomer(string name, string adress, int zipcodeId)
        {
            CustomerRepository.AddCustomer(new Customer(name, adress, zipcodeId));
            return Ok();
        }
    }

}

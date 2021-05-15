using Microsoft.AspNetCore.Mvc;
using MyPersistance.Entities;
using MyPersistance.Repositories;

namespace TemaS2MiercuriV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private FreelancerRepository FreelancerRepository { get; set; }
        public FreelancerController(FreelancerRepository freelancerRepository)
        {
            FreelancerRepository = freelancerRepository;
        }

        [HttpGet("displayFreelancers")]
        public IActionResult DisplayFreelancers()
        {
            var freelancers = FreelancerRepository.GetFreelancers();
            return Ok(freelancers);
        }

        [HttpPost("addFreelancer")]
        public IActionResult AddFreelancer(string name, float price, string adress, int zipcodeId)
        {
            FreelancerRepository.AddFreelancer(new Freelancer(name, price, adress, zipcodeId));
            return Ok();
        }
    }

}

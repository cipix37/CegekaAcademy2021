﻿
using Microsoft.AspNetCore.Mvc;
using Persistance.Repositories;

namespace WorkLoad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private IFreelancerRepository _freelancerRepository { get; set; }
        public FreelancerController (IFreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }


        [HttpGet("displayFreelancers")]
        public  IActionResult DisplayFreelancers()
        {
            var freelancers = _freelancerRepository.GetFreelancers();
            return Ok(freelancers);
        }

        [HttpPost("addFreelancer")]
        public  IActionResult AddFreelancer(string firstName, string lastName )
        {
            _freelancerRepository.AddFreelancer(firstName, lastName);
            return Ok();
        }
        [HttpPost("addWorkLoad")]
        public  IActionResult AddWorkLoad(int freelancerId, int noOfHours)
        {
            _freelancerRepository.AddWorkLoad(freelancerId, noOfHours);
            return Ok();
        }
    }
    
}

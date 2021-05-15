using Microsoft.AspNetCore.Mvc;
using MyPersistance.Entities;
using MyPersistance.Repositories;

namespace TemaS2MiercuriV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipcodeController : ControllerBase
    {
        private ZipcodeRepository ZipcodeRepository { get; set; }
        public ZipcodeController(ZipcodeRepository zipcodeRepository)
        {
            ZipcodeRepository = zipcodeRepository;
        }

        [HttpGet("displayZipcodes")]
        public IActionResult DisplayZipcodes()
        {
            var zipcodes = ZipcodeRepository.GetZipcodes();
            return Ok(zipcodes);
        }

        [HttpPost("addZipcode")]
        public IActionResult AddZipcode(int code, string state, string county, string city)
        {
            ZipcodeRepository.AddZipcode(new Zipcode(code, state, county, city));
            return Ok();
        }
    }

}

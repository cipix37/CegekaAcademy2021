using Microsoft.AspNetCore.Mvc;
using MyPersistance.Entities;
using MyPersistance.Repositories;
using System;

namespace TemaS2MiercuriV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorklogController : ControllerBase
    {
        private WorklogRepository WorklogRepository { get; set; }
        public WorklogController(WorklogRepository worklogRepository)
        {
            WorklogRepository = worklogRepository;
        }


        [HttpGet("displayWorklogs")]
        public IActionResult Displayworklogs()
        {
            var worklogs = WorklogRepository.GetWorklogs();
            return Ok(worklogs);
        }

        [HttpPost("addWorklog")]
        public IActionResult Addworklog(int freelancerId, DateTime datetime, int hours, int projectId)
        {
            if (0 < hours && hours <= 8)
            {
                WorklogRepository.AddWorklog(new Worklog(freelancerId, datetime, hours, projectId));
            }
            return Ok();
        }
    }
}

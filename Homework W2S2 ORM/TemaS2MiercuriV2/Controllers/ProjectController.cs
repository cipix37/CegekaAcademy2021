using Microsoft.AspNetCore.Mvc;
using MyPersistance.Entities;
using MyPersistance.Repositories;

namespace TemaS2MiercuriV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private ProjectRepository ProjectRepository { get; set; }
        public ProjectController(ProjectRepository projectRepository)
        {
            ProjectRepository = projectRepository;
        }


        [HttpGet("displayProjects")]
        public IActionResult DisplayProjects()
        {
            var projects = ProjectRepository.GetProjects();
            return Ok(projects);
        }

        [HttpPost("addProject")]
        public IActionResult AddProject(string name, int estimation, int customerId)
        {
            ProjectRepository.AddProject(new Project(name, estimation, customerId));
            return Ok();
        }

        [HttpGet("projectWork")]
        public IActionResult ProjectWork()
        {
            string output = "";
            var projects = ProjectRepository.GetProjects();
            foreach(Project project in projects)
            {
                output += $"{project.Estimation}\n";
            }
            return Ok(output);
        }
    }
}

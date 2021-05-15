using System.Collections.Generic;
using System.Linq;
using MyPersistance.Data;
using MyPersistance.Entities;

namespace MyPersistance.Repositories
{
    public class ProjectRepository
    {
        private readonly TemaS2MiercuriV2Context _context;

        public ProjectRepository(TemaS2MiercuriV2Context context)
        {
            _context = context;
        }

        public List<Project> GetProjects()
        {
            return _context.Project.ToList();
        }

        public void AddProject(Project project)
        {
            _context.Project.Add(project);
            _context.SaveChanges();
        }
    }
}

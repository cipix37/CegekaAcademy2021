using System.Collections.Generic;
using System.Linq;
using MyPersistance.Data;
using MyPersistance.Entities;

namespace MyPersistance.Repositories
{
    public class WorklogRepository
    {
        private readonly TemaS2MiercuriV2Context _context;

        public WorklogRepository(TemaS2MiercuriV2Context context)
        {
            _context = context;
        }

        public List<Worklog> GetWorklogs()
        {
            return _context.Worklog.ToList();
        }

        public void AddWorklog(Worklog worklog)
        {
            _context.Worklog.Add(worklog);
            _context.SaveChanges();
        }
    }
}

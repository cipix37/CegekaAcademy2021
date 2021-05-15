using System.Collections.Generic;
using System.Linq;
using MyPersistance.Data;
using MyPersistance.Entities;

namespace MyPersistance.Repositories
{
    public class FreelancerRepository
    {
        private readonly TemaS2MiercuriV2Context _context;

        public FreelancerRepository(TemaS2MiercuriV2Context context)
        {
            _context = context;
        }

        public List<Freelancer> GetFreelancers()
        {
            return _context.Freelancer.ToList();
        }

        public void AddFreelancer(Freelancer freelancer)
        {
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }
    }
}

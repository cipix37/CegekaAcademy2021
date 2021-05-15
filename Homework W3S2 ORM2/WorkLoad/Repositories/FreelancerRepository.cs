using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Data;

namespace WorkLoad.Repositories
{
    public class FreelancerRepository : IFreelancerRepository
    {
        private readonly WorkLoadDbContext _context;
        public FreelancerRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public List<Freelancer> GetFreelancers()
        {
            return _context.Freelancer.ToList();
        }
        public void AddFreelancer (Freelancer freelancer)
        {
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }
        public void AddWorkLoad (int freelancerId, int noOfHours)
        {
            var workLoad = new Entities.WorkLoad()
            {
                NoOfHours = 8,
                FreelancerId = freelancerId
            };
           _context.WorkLoad.Add(workLoad);
            _context.SaveChanges();
        }
    }
}

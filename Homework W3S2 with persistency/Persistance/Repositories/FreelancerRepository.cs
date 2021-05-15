
using Persistance.Data;
using Persistance.Entities;
using System.Collections.Generic;
using System.Linq;
namespace Persistance.Repositories
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
        public void AddFreelancer(string firstName,  string lastName)
        {
            var freelancer = new Freelancer() { FirstName = firstName, LastName = lastName };
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }
        public void AddWorkLoad(int freelancerId, int noOfHours)
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

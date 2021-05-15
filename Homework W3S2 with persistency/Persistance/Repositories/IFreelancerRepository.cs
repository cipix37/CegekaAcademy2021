using Persistance.Entities;
using System.Collections.Generic;

namespace Persistance.Repositories
{
    public interface IFreelancerRepository
    {
        public List<Freelancer> GetFreelancers();
        public void AddFreelancer(string firstName, string lastName);
        public void AddWorkLoad(int freelancerId, int noOfHours);
    }
}

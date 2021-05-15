using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Repositories
{
    public interface IFreelancerRepository
    {
        public List<Freelancer> GetFreelancers();
        public void AddFreelancer(Freelancer freelancer);
        public void AddWorkLoad(int freelancerId, int noOfHours);
    }
}

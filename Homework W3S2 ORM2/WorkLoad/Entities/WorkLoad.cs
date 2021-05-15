using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class WorkLoad
    {
       
        public int Id { get; set; }
        
        public int NoOfHours { get; set; }

        public int FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
    }
}


namespace Persistance.Entities
{
    public class WorkLoad
    {

        public int Id { get; set; }

        public int NoOfHours { get; set; }

        public int FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
    }
}

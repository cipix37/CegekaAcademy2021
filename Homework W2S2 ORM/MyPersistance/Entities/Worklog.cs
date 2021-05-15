using System;

namespace MyPersistance.Entities
{
    public class Worklog
    {
        public int Id { get; set; }
        public int FreelancerId { get; set; }
        public DateTime DateTime { get; set; }
        public int Hours { get; set; }
        public int ProjectId { get; set; }

        public Worklog() { }
        public Worklog(int freelancerId, DateTime datetime, int hours, int projectId) 
        {
            FreelancerId = freelancerId;
            DateTime = datetime;
            Hours = hours;
            ProjectId = projectId;
        }

    }
}
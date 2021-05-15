using Microsoft.EntityFrameworkCore;
using Persistance.Configurations;
using Persistance.Entities;

namespace Persistance.Data
{
    public sealed class WorkLoadDbContext : DbContext
    {
        public WorkLoadDbContext() { }

        public WorkLoadDbContext(DbContextOptions<WorkLoadDbContext> options) : base(options)
        {

        }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<WorkLoad> WorkLoad { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfiguration());

        
        }
    }
}

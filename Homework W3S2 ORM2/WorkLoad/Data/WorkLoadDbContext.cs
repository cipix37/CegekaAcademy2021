using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Configurations;

namespace WorkLoad.Data
{
    public sealed class WorkLoadDbContext : DbContext
    {
        public WorkLoadDbContext() { }

        public WorkLoadDbContext(DbContextOptions<WorkLoadDbContext> options) : base(options)
        {

        }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Entities.WorkLoad> WorkLoad { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfiguration());

        
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MyPersistance.Configurations;
using MyPersistance.Entities;

namespace MyPersistance.Data
{
    public sealed class TemaS2MiercuriV2Context : DbContext
    {
        public TemaS2MiercuriV2Context() { }

        public TemaS2MiercuriV2Context(DbContextOptions<TemaS2MiercuriV2Context> options) : base(options)
        {

        }
        public DbSet<Zipcode> Zipcode { get; set; }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Worklog> Worklog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ZipcodeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WorklogEntityConfiguration());

        }
    }
}

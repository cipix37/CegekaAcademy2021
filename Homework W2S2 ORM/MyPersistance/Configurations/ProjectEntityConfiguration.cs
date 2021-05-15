using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPersistance.Entities;

namespace MyPersistance.Configurations
{
    public class ProjectEntityConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Estimation).IsRequired();
            builder.Property(c => c.CustomerId).IsRequired();
        }
    }
}

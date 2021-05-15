using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPersistance.Entities;

namespace MyPersistance.Configurations
{
    public class WorklogEntityConfiguration : IEntityTypeConfiguration<Worklog>
    {
        public void Configure(EntityTypeBuilder<Worklog> builder)
        {
            builder.Property(f => f.FreelancerId).IsRequired();
            builder.Property(d => d.DateTime).IsRequired();
            builder.Property(h => h.Hours).IsRequired();
            builder.Property(p => p.ProjectId).IsRequired();
        }
    }
}

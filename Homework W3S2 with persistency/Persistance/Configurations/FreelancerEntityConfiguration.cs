using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Entities;

namespace Persistance.Configurations
{
    public class FreelancerEntityConfiguration : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {

            builder.Property(f => f.FirstName).IsRequired().HasMaxLength(25);
            builder.Property(l => l.LastName).IsRequired();
        }
    }
}

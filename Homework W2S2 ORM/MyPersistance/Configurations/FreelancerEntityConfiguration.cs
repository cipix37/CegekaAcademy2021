using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPersistance.Entities;

namespace MyPersistance.Configurations
{
    public class FreelancerEntityConfiguration : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(25);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(a => a.Adress).IsRequired().HasMaxLength(200);
            builder.Property(z => z.ZipcodeId).IsRequired();
        }
    }
}

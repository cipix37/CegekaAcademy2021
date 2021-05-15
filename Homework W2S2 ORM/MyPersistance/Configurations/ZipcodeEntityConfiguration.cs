using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPersistance.Entities;

namespace MyPersistance.Configurations
{
    public class ZipcodeEntityConfiguration : IEntityTypeConfiguration<Zipcode>
    {
        public void Configure(EntityTypeBuilder<Zipcode> builder)
        {
            builder.Property(c => c.Code).IsRequired().IsFixedLength(true).HasMaxLength(5);
            builder.Property(f => f.State).IsRequired().HasMaxLength(25);
            builder.Property(o => o.County).IsRequired().HasMaxLength(25);
            builder.Property(i => i.City).IsRequired().HasMaxLength(25);
        }
    }
}

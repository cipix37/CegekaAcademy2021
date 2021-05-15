using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPersistance.Entities;

namespace MyPersistance.Configurations
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(5);
            builder.Property(a => a.Adress).IsRequired().HasMaxLength(100);
            builder.Property(z => z.ZipcodeId).IsRequired();
        }
    }
}

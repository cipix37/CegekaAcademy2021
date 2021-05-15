using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Configurations
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

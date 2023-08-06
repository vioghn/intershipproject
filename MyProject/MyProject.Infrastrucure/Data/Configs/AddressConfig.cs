using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyProject.Domain.Entities;


namespace MyProject.Infrastrucure.Data.Configs
{
 
        public class AddressConfiguraion : IEntityTypeConfiguration<Address>
        {
            public void Configure(EntityTypeBuilder<Address> builder)
            {
                builder.ToTable("Addresses");
                builder.HasKey(x => x.AddressId);
                builder.Property(x => x.Country).HasMaxLength(50);
                builder.Property(x => x.City).HasMaxLength(50);
                builder.Property(x => x.Region).HasMaxLength(50);
                builder.Property(x => x.PostalCode).HasMaxLength(15);
                //builder.HasOne(e => e.).WithOne(c => c.Address).HasForeignKey<Address>(a => a.AddressId);
        }
        }
    
}


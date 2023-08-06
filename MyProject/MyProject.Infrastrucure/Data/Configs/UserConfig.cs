using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain.Entities;

namespace MyProject.Infrastrucure.Data.Configs
{
    public class UserConfiguraion : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserId);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Mobile).HasMaxLength(50);

            builder.HasOne(e => e.Role).WithMany(c => c.Users);
            builder.HasOne(e => e.Address).WithOne(c => c.User).HasForeignKey<User>(a => a.UserId);

        }
    }
}

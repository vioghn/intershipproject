using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Infrastructure.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Address Address { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; } //  one role can be for N users but I considered that one user can just have one role so the relation is 1 to N.
    }

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
          
        }
    }
}

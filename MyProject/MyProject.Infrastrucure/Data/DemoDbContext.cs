using MyProject.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Infrastructure.Data
{
    public class DemoDbContext : DbContext

    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DemoDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // to identify to db our configurations
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguraion());
            modelBuilder.ApplyConfiguration(new RoleConfiguraion());
            modelBuilder.ApplyConfiguration(new UserConfiguraion());

        }
    }

    public class BloggingContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
    {
        public DemoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DemoDbContext>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8P7BMBK;Database=MyProjectDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            return new DemoDbContext(optionsBuilder.Options);


        }
    }
}

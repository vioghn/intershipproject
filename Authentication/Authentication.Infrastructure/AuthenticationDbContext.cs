using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Authentication.Infrastructure
{
    public class AuthenticationDbContext : DbContext
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        public class BloggingContextFactory : IDesignTimeDbContextFactory<AuthenticationDbContext>
        {
            public AuthenticationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AuthenticationDbContext>();
                optionsBuilder.UseSqlServer("server=DESKTOP-CMR9S4V; database=Authentication_Db; Trusted_Connection=true;Encrypt=false;TrustServerCertificate=true");
                return new AuthenticationDbContext(optionsBuilder.Options);


            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Infrastructure
{
    public static class Extention
    {
        public static IServiceCollection Addextentions(this IServiceCollection services)
        {
            services.AddDbContext<AuthenticationDbContext>(opt =>
            opt.UseSqlServer("server=DESKTOP-CMR9S4V; database=Authentication_Db; Trusted_Connection=true;Encrypt=false;TrustServerCertificate=true"));
            return services;
        }
    }
}


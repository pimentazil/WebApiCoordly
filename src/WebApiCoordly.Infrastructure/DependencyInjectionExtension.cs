using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiCoordly.Domain.Repositories;
using WebApiCoordly.Domain.Repositories.Product;
using WebApiCoordly.Infrastructure.DataAccess;
using WebApiCoordly.Infrastructure.DataAccess.Repositories;

namespace WebApiCoordly.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddRepositories(services);
            AddDbContext(services, configuration);    
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductWriteOnlyRepository, ProductRepository>();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<CoordlyDbContext>(config => config.UseSqlServer(connectionString));
        }
    }
}

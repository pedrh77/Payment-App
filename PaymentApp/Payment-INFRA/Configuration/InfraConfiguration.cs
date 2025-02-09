using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payment_INFRA.Persistence;
using Pomelo.EntityFrameworkCore.MySql;

namespace Payment_INFRA
{

    public static class InfraConfigDependence
    {
        public static void ConfigureInfra(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration["ConnectionStrings:PaymentDatabaseString"];


            services.AddDbContext<PaymentDatabaseContext>(opt => opt.Use (connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}

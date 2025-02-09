using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payment_APP.UseCases.User;

namespace Payment_APP.Configuration
{
    public static class ApplicationConfiguration
    {
        public static void ConfigureApplicatipon(this IServiceCollection services, IConfiguration configuration)
        {
            services
            .AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(typeof(RegisterUserQueryHandler).Assembly);
            });
        }
    }
}

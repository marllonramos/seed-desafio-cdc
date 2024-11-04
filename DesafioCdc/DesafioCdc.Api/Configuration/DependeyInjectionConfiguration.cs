using DesafioCdc.ApplicationService.Services;
using DesafioCdc.Domain.Repositories;
using DesafioCdc.Infra.Data;

namespace DesafioCdc.Api.Configuration
{
    public static class DependeyInjectionConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }
    }
}

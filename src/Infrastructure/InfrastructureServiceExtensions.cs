using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Infrastructure.Data;
using Infrastructure.Data.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SteelDonkey.UseCases.CompetenceElements.List;
using SteelDonkey.UseCases.People.List;

namespace Infrastructure
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            ConfigurationManager config,
            ILogger logger)
        {
            string? connectionString = config.GetConnectionString("ApplicationDbConnection");
            Guard.Against.Null(connectionString);
            services.AddDbContext<SteelDonkeyContext>(options =>
                options.UseSqlServer(connectionString));
            services
                .AddScoped(typeof(IRepository<>), typeof(EfRepository<>))
                .AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>))
                .AddScoped<IListPeopleQueryService, ListPeopleQueryService>()
                .AddScoped<IListCompetenceElementQueryService, ListCompetenceElementQueryService>();

            

            logger.LogInformation("{Project} services registered", "Infrastructure");

            return services;
        }
    }
}

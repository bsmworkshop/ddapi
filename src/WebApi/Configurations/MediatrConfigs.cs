using SteelDonkey.Core.Entities.People;
using SteelDonkey.UseCases.People.Get;
using System.Reflection;

namespace SteelDonkey.WebApi.Configurations
{
    public static class MediatrConfigs
    {
        public static IServiceCollection AddMediatrConfigs(this IServiceCollection services)
        {
            var mediatrAssemblies = new[]
            {
                Assembly.GetAssembly(typeof(Person)),
                Assembly.GetAssembly(typeof(GetPersonHandler))
            };

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatrAssemblies));

            return services;
                
        }
    }
}

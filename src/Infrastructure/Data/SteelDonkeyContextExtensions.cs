using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data
{
    public static class SteelDonkeyContextExtensions
    {
        public static void AddApplicationDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<SteelDonkeyContext>(options =>
            options.UseSqlServer(connectionString));
    }
}

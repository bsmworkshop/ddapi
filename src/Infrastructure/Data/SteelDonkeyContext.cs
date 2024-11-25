using Microsoft.EntityFrameworkCore;
using SteelDonkey.Core.Entities.People;
using System.Reflection;

namespace Infrastructure.Data
{
    public class SteelDonkeyContext(DbContextOptions<SteelDonkeyContext> options) 
        : DbContext(options)
    {
        public DbSet<Person> People => Set<Person>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

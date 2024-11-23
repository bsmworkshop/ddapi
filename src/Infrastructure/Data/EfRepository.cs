using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SteelDonkey.Core.Interfaces;

namespace Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T> where T : class, IAggregateRoot
    {
        public EfRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

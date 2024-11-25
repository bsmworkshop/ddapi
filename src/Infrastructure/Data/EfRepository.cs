using Ardalis.SharedKernel;
using Ardalis.Specification.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class EfRepository<T>(SteelDonkeyContext context) 
        : RepositoryBase<T>(context), IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
    }
}

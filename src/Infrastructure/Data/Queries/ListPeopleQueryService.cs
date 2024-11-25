using Microsoft.EntityFrameworkCore;
using SteelDonkey.UseCases.People;
using SteelDonkey.UseCases.People.List;

namespace Infrastructure.Data.Queries
{
    public class ListPeopleQueryService(SteelDonkeyContext _context) : IListPeopleQueryService
    {
        public async Task<IEnumerable<PersonDto>> ListAsync()
        {
            var result = await _context.Database.SqlQuery<PersonDto>(
                $"SELECT [Id], [FamilyName], [GivenName], [OtherNames] FROM [Person] WHERE [Id] > 0 AND [IsArchived] = 0 AND [DeletedAt] IS NULL AND [DeletedById] IS NULL"
                ).ToListAsync();

            return result;
        }
    }
}

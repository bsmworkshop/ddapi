using Microsoft.EntityFrameworkCore;
using SteelDonkey.UseCases.CompetenceElements;
using SteelDonkey.UseCases.CompetenceElements.List;

namespace Infrastructure.Data.Queries
{
    public class ListCompetenceElementQueryService(SteelDonkeyContext _context) : IListCompetenceElementQueryService
    {
        public async Task<IEnumerable<CompetenceElementDto>> ListAsync()
        {
            var result = await _context.Database.SqlQuery<CompetenceElementDto>(
                $"SELECT e.[Id], e.[Label], e.[CompetenceElementGroupId] AS [GroupId], g.[Label] AS [GroupLabel] FROM [CompetenceElement] e LEFT JOIN [CompetenceElementGroup] g ON g.[Id] = e.[CompetenceElementGroupId] WHERE e.[DeletedAt] IS NULL AND e.[DeletedById] IS NULL AND g.[DeletedAt] IS NULL AND g.[DeletedById] IS NULL"
                ).ToListAsync();

            return result;
        }
    }
}

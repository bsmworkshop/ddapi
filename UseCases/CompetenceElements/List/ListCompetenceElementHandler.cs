using Ardalis.Specification;
using SteelDonkey.Core.Entities.CompetencyElements;
using SteelDonkey.Core.Entities.CompetencyElements.Specifications;

namespace SteelDonkey.UseCases.CompetenceElements.List
{
    public class ListCompetenceElementHandler(IReadRepository<CompetenceElement> _repository)
        : IQueryHandler<ListCompetenceElementQuery, Result<IEnumerable<CompetenceElementGroupDto>>>
    {
        public async Task<Result<IEnumerable<CompetenceElementGroupDto>>> Handle(ListCompetenceElementQuery request, CancellationToken cancellationToken)
        {
            var spec = new CompetenceElementWithGroupSpec();
            var data = await _repository.ListAsync(cancellationToken);

            if (data == null) return Result.NotFound();

            var groups = data.Select(e => new { e.CompetenceElementGroupId, e.CompetenceElementGroup.Label }).Distinct().ToList();

            return Result<IEnumerable<CompetenceElementGroupDto>>.Success(groups
                .Select(e => new CompetenceElementGroupDto(
                    e.CompetenceElementGroupId,
                    e.Label,
                    data
                        .Where(x => x.CompetenceElementGroupId == e.CompetenceElementGroupId)
                        .Select(x => new CompetenceElementDto(x.Id, x.Label))
                        )
                )
               );
        }
    }
}

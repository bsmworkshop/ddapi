namespace SteelDonkey.UseCases.CompetenceElements.List
{
    public record ListCompetenceElementQuery() 
        : IQuery<Result<IEnumerable<CompetenceElementGroupDto>>>;
}

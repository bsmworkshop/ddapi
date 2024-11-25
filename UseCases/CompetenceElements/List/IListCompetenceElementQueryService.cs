namespace SteelDonkey.UseCases.CompetenceElements.List
{
    public interface IListCompetenceElementQueryService
    {
        Task<IEnumerable<CompetenceElementDto>> ListAsync();
    }
}

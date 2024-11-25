namespace SteelDonkey.UseCases.CompetenceElements
{
    public record CompetenceElementGroupDto(int Id, string Label, IEnumerable<CompetenceElementDto> Elements);
}

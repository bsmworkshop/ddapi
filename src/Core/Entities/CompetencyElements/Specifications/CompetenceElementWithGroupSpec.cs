namespace SteelDonkey.Core.Entities.CompetencyElements.Specifications
{
    public class CompetenceElementWithGroupSpec : Specification<CompetenceElement>
    {
        public CompetenceElementWithGroupSpec() =>
            Query
                .Include(e => e.CompetenceElementGroup)
                .Where(e => e.DeletedAt == null && e.DeletedById == null);
    }
}

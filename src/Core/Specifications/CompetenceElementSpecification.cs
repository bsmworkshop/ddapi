using Ardalis.Specification;
using SteelDonkey.Core.Entities.Competency;

namespace SteelDonkey.Core.Specifications
{
    public class CompetenceElementSpecification : Specification<CompetenceElement>
    {
        public CompetenceElementSpecification(int competenceElementId)
        {
            Query
                .Where(x => x.Id == competenceElementId);
        }
    }
}

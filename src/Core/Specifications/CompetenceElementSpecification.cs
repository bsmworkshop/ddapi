using Ardalis.Specification;
using Core.Entities.Competency;

namespace Core.Specifications
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

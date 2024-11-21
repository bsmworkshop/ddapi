using Ardalis.Specification;
using Core.Entities.People;

namespace Core.Specifications
{
    public class PersonWithCompetenceAssessmentsSpecification : Specification<Person>
    {
        public PersonWithCompetenceAssessmentsSpecification(int personId)
        {
            Query
                .Include(x => x.CompetenceAssessments)
                .Where(x => x.Id == personId);
        }

        public PersonWithCompetenceAssessmentsSpecification(int personId, int competenceElementId)
        {
            Query
                .Include(x => x.CompetenceAssessments)
                .Where(x => x.Id == personId && x.CompetenceAssessments.Any(c => c.CompetenceElementId == competenceElementId));
        }
    }
}

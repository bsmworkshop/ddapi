using Core.Entities.People;
using Core.Interfaces;

namespace Core.Entities.Competency
{
    public class CompetenceAssessment : BaseEntity<Guid>, IAggregateRoot
    {
#pragma warning disable CS8618
        private CompetenceAssessment() { }

        public int PersonId { get; private set; }
        public Person Person { get; private set; }

        public int CompetenceElementId { get; private set; }
        public CompetenceElement CompetenceElement { get; private set; }

        public CompetenceAssessmentOutcome CompetenceAssessmentOutcome { get; private set; }

    }
}

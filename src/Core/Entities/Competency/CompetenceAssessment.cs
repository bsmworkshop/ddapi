using SteelDonkey.Core.Entities;
using SteelDonkey.Core.Entities.People;
using SteelDonkey.Core.Interfaces;

namespace SteelDonkey.Core.Entities.Competency
{
    public class CompetenceAssessment : BaseEntity<Guid>, IAggregateRoot
    {
#pragma warning disable CS8618
        private CompetenceAssessment() { }

        public CompetenceAssessment(int personId, int assessorId, int competenceElementId, CompetenceAssessmentOutcome outcome, DateTime assessmentDate, DateTime? expiryDate, string notes)
        {
            PersonId = personId;
            AssessorPersonId = assessorId;
            Outcome = outcome;
            AssessmentDate = assessmentDate;
            ExpiryDate = expiryDate;
            Notes = notes;
        }

        public int PersonId { get; private set; }
        public Person Person { get; private set; }

        public int AssessorPersonId { get; private set; }
        public Person Assessor { get; private set; }

        public int CompetenceElementId { get; private set; }
        public CompetenceElement CompetenceElement { get; private set; }

        public CompetenceAssessmentOutcome Outcome { get; private set; }

        public DateTime AssessmentDate { get; private set; }
        public DateTime? ExpiryDate { get; private set; }
        public string Notes { get; private set; }
    }
}

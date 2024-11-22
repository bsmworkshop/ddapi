using SteelDonkey.Core.Entities.Competency;

namespace SteelDonkey.Core.Interfaces
{
    public interface ICompetenceService
    {
        Task CreateCompetenceAssessment(
            int assessedPersonId,
            int assessorPersonId,
            int competenceAssessmentId,
            DateTime assessmentDate,
            CompetenceAssessmentOutcome outcome,
            string notes,
            DateTime? expiryDate);
    }
}

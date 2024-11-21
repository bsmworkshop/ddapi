using Core.Entities.Competency;

namespace Core.Interfaces
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

using Ardalis.GuardClauses;
using Core.Exceptions;
using SteelDonkey.Core.Entities.Competency;

namespace SteelDonkey.Core.Extensions
{
    public static class GuardExtensions
    {
        public static void AssessorIsNotQualified(this IGuardClause clause, CompetenceAssessment? assessment)
        {
            if (assessment == null || assessment.Outcome != CompetenceAssessmentOutcome.Assessor || assessment.ExpiryDate != null && assessment.ExpiryDate < DateTime.UtcNow)
                throw new PersonIsNotCurrentAssessorException();
        }
    }
}

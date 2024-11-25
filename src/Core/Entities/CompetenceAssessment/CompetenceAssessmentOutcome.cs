using Ardalis.SmartEnum;

namespace SteelDonkey.Core.Entities.CompetenceAssessment
{
    public sealed class CompetenceAssessmentOutcome : SmartEnum<CompetenceAssessmentOutcome>
    {
        public static readonly CompetenceAssessmentOutcome NoLongerRequired = new CompetenceAssessmentOutcome(nameof(NoLongerRequired), 1);
        public static readonly CompetenceAssessmentOutcome NotCompetent = new CompetenceAssessmentOutcome(nameof(NotCompetent), 2);
        public static readonly CompetenceAssessmentOutcome Competent = new CompetenceAssessmentOutcome(nameof(Competent), 3);
        public static readonly CompetenceAssessmentOutcome Assessor = new CompetenceAssessmentOutcome(nameof(Assessor), 4);

        private CompetenceAssessmentOutcome(string name, int value)
            : base(name, value)
        {
        }
    }
}

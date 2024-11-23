using SteelDonkey.Core.Entities.Competency;
using SteelDonkey.Core.Entities.People;
using SteelDonkey.Core.Interfaces;

namespace SteelDonkey.Core.Services
{
    public class CompetenceService : ICompetenceService
    {
        private readonly IRepository<CompetenceAssessment> _competenceAssessmentRepository;
        private readonly IReadRepository<Person> _personRepository;

        public CompetenceService(
            IRepository<CompetenceAssessment> competenceAssessmentRepository,
            IReadRepository<Person> personRepository)
        {
            _competenceAssessmentRepository = competenceAssessmentRepository;
            _personRepository = personRepository;
        }
        public async Task CreateCompetenceAssessment(int assessedPersonId, int assessorPersonId, int competenceElementId, DateTime assessmentDate, CompetenceAssessmentOutcome outcome, string notes, DateTime? expiryDate)
        {
            throw new NotImplementedException();

        }
    }
}

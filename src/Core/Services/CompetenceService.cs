using Ardalis.GuardClauses;
using Core.Specifications;
using SteelDonkey.Core.Entities.Competency;
using SteelDonkey.Core.Entities.People;
using SteelDonkey.Core.Extensions;
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
            var assessorPersonSpecification = new PersonWithCompetenceAssessmentsSpecification(assessorPersonId, competenceElementId);
            var assessorPerson = await _personRepository.FirstOrDefaultAsync(assessorPersonSpecification);

            Guard.Against.Null(assessorPerson, nameof(assessorPerson));
            var assessorAssessment = assessorPerson?.CompetenceAssessments.SingleOrDefault();
            Guard.Against.AssessorIsNotQualified(assessorAssessment);

            var assessedPersonSpecification = new PersonSpecification(assessorPersonId);
            var assessedPerson = await _personRepository.FirstOrDefaultAsync(assessedPersonSpecification);
            Guard.Against.Null(assessedPerson, nameof(assessedPerson));

            var competenceAssessment = new CompetenceAssessment(
                assessorPersonId,
                assessorPersonId,
                competenceElementId,
                outcome,
                assessmentDate,
                expiryDate,
                notes);

            await _competenceAssessmentRepository.AddAsync(competenceAssessment);

        }
    }
}

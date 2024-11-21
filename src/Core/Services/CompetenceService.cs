using Core.Entities.Competency;
using Core.Entities.People;
using Core.Interfaces;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
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

            var assessedPersonSpecification = new PersonSpecification(assessorPersonId);
            var assessedPerson = await _personRepository.FirstOrDefaultAsync(assessedPersonSpecification);

            
        }
    }
}

using Core.Entities.Competency;
using Core.Interfaces;

namespace Core.Entities.People
{
    public class Person : BaseEntity<int>, IAggregateRoot
    {
#pragma warning disable CS8618
        private Person() { }

        public HumanName Name { get; private set; }
        public List<CompetenceAssessment> CompetenceAssessments { get; private set; }
    }
}

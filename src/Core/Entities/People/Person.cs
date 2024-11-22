using SteelDonkey.Core.Entities;
using SteelDonkey.Core.Entities.Competency;
using SteelDonkey.Core.Interfaces;

namespace SteelDonkey.Core.Entities.People
{
    public class Person : BaseEntity<int>, IAggregateRoot
    {
#pragma warning disable CS8618
        private Person() { }

        public HumanName Name { get; private set; }
        public List<CompetenceAssessment> CompetenceAssessments { get; private set; }
    }
}

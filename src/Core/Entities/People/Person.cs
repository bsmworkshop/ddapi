using SteelDonkey.Core.Interfaces;

namespace SteelDonkey.Core.Entities.People
{
    public class Person : BaseEntity<int>, IAggregateRoot
    {
#pragma warning disable CS8618
        private Person() { }

        public Person(string familyName, string givenName, string? otherNames)
        {
            FamilyName = familyName;
            GivenName = givenName;
            OtherNames = otherNames;
        }

        public string FamilyName { get; private set; }
        public string GivenName { get; private set; }
        public string? OtherNames { get; private set; }
    }
}

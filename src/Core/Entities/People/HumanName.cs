namespace Core.Entities.People
{
    public class HumanName
    {
#pragma warning disable CS8618
        private HumanName() { }

        public HumanName(string familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        }
        
        public HumanName(string familyName, string givenName, string otherNames)
        {
            FamilyName = familyName;
            GivenName = givenName;
            OtherNames = otherNames;
        }

        public string FamilyName { get; private set; }
        public string GivenName { get; private set; }
        public string? OtherNames { get; private set; }

        public override string ToString()
            => $"{GivenName} {FamilyName}";

        public string FullName
            => $"{GivenName}{(string.IsNullOrEmpty(OtherNames) ? string.Empty : $" {OtherNames}")} {FamilyName}";

        public string DisplayName
            => $"{FamilyName}, {GivenName}";

        public string FullDisplayName
            => $"{DisplayName}{(string.IsNullOrEmpty(OtherNames) ? string.Empty : $" {OtherNames}")}";

    }
}

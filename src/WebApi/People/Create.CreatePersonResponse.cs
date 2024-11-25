namespace SteelDonkey.WebApi.People
{
    public class CreatePersonResponse(int id, string familyName, string givenName, string? otherNames)
    {
        public int Id { get; set; } = id;
        public string FamilyName { get; set; } = familyName;
        public string GivenName { get; set; } = givenName;
        public string? OtherNames { get; set; } = otherNames;
    }
}

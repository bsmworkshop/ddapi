namespace SteelDonkey.Core.Interfaces
{
    public interface IPersonService
    {
        Task CreatePerson(string familyName, string givenName, string? otherNames);
        Task ArchivePerson(int personId);
    }
}

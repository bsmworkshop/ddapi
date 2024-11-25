namespace SteelDonkey.UseCases.People.List
{
    public interface IListPeopleQueryService
    {
        Task<IEnumerable<PersonDto>> ListAsync();
    }
}

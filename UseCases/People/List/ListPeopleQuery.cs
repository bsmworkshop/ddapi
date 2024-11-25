namespace SteelDonkey.UseCases.People.List
{
    public record ListPeopleQuery(int? Skip, int? Take) 
        : IQuery<Result<IEnumerable<PersonDto>>>;
}

namespace SteelDonkey.UseCases.People.Get
{
    public record GetPersonQuery(int PersonId) : IQuery<Result<PersonDto>>;
}

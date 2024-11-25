namespace SteelDonkey.UseCases.People.Create
{
    public record CreatePersonCommand(int CreatedById, string FamilyName, string GivenName, string? OtherNames)
        : ICommand<Result<int>>;
}

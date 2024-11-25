using SteelDonkey.Core.Entities.People;

namespace SteelDonkey.UseCases.People.Create
{
    public class CreatePersonHandler(IRepository<Person> _repository)
        : ICommandHandler<CreatePersonCommand, Result<int>>
    {
        public async Task<Result<int>> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var newPerson = new Person(request.CreatedById, request.FamilyName, request.GivenName, request.OtherNames);
            var createdItem = await _repository.AddAsync(newPerson, cancellationToken);

            return createdItem.Id;
        }
    }
}

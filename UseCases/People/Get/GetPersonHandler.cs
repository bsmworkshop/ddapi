using SteelDonkey.Core.Entities.People;
using SteelDonkey.Core.Entities.People.Specifications;

namespace SteelDonkey.UseCases.People.Get
{
    public class GetPersonHandler(IReadRepository<Person> _repository)
        : IQueryHandler<GetPersonQuery, Result<PersonDto>>
    {
        public async Task<Result<PersonDto>> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            var spec = new PersonByIdSpec(request.PersonId);
            var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
            if (entity == null) return Result.NotFound();

            return new PersonDto(entity.Id, entity.FamilyName, entity.GivenName, entity.OtherNames);
        }
    }
}

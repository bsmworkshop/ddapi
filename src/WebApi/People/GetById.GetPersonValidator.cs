using FluentValidation;

namespace SteelDonkey.WebApi.People
{
    public class GetPersonValidator :Validator<GetPersonByIdRequest>
    {
        public GetPersonValidator()
        {
            RuleFor(x => x.PersonId)
                .GreaterThan(0);
        }
    }
}

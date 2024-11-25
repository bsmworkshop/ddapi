using FluentValidation;

namespace SteelDonkey.WebApi.People
{
    public class CreatePersonValidator : Validator<CreatePersonRequest>
    {
        public CreatePersonValidator()
        {
            RuleFor(x => x.FamilyName)
                .NotEmpty()
                .WithMessage("FamilyName is required.")
                .MinimumLength(2)
                .MaximumLength(70);

            RuleFor(x => x.GivenName)
                .NotEmpty()
                .WithMessage("GivenName is required.")
                .MinimumLength(2)
                .MaximumLength(70);

            RuleFor(x => x.FamilyName)
                .MaximumLength(100)
                .WithMessage("OtherNames must be less than 100 characters.");
                
        }
    }
}

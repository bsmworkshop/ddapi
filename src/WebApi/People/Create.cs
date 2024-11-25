
using SteelDonkey.UseCases.People.Create;

namespace SteelDonkey.WebApi.People
{
    public class Create(IMediator _mediator)
        : Endpoint<CreatePersonRequest, CreatePersonResponse>
    {
        public override void Configure()
        {
            Post(CreatePersonRequest.Route);
            AllowAnonymous();
            Summary(s =>
            {
                s.ExampleRequest = new CreatePersonRequest { FamilyName = "Smith", GivenName = "John" };
            });
        }

        public override async Task HandleAsync(CreatePersonRequest req, CancellationToken ct)
        {
            var result = await _mediator.Send(new CreatePersonCommand(0, req.FamilyName, req.GivenName, req.OtherNames), ct);
            if (result.IsSuccess)
            {
                Response = new CreatePersonResponse(result.Value, req.FamilyName, req.GivenName, req.OtherNames);
                return;
            }
        }
    }
}

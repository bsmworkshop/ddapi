
using SteelDonkey.UseCases.People.Get;

namespace SteelDonkey.WebApi.People
{
    public class GetById(IMediator _mediator)
        : Endpoint<GetPersonByIdRequest, PersonRecord>
    {
        public override void Configure()
        {
            Get(GetPersonByIdRequest.Route);
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetPersonByIdRequest req, CancellationToken ct)
        {
            var query = new GetPersonQuery(req.PersonId);

            var result = await _mediator.Send(query, ct);

            if (result.Status == ResultStatus.NotFound)
            {
                await SendNotFoundAsync(ct);
                return;
            }

            if (result.IsSuccess)
            {
                Response = new PersonRecord(result.Value.Id, result.Value.FamilyName, result.Value.GivenName, result.Value.OtherNames);
            }
        }
    }
}

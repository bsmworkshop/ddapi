
using SteelDonkey.UseCases.People.List;

namespace SteelDonkey.WebApi.People
{
    public class List(IMediator _mediator)
        : EndpointWithoutRequest<PeopleListResponse>
    {
        public override void Configure()
        {
            Get("/People");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var result = await _mediator.Send(new ListPeopleQuery(null, null), ct);

            if (result.IsSuccess)
            {
                Response = new PeopleListResponse
                {
                    People = result.Value.Select(p => new PersonRecord(
                        p.Id,
                        p.FamilyName,
                        p.GivenName,
                        p.OtherNames
                    )).ToList()
                };
            }

        }
    }
}

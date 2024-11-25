using SteelDonkey.UseCases.CompetenceElements.List;
namespace SteelDonkey.WebApi.CompetenceElement
{
    public class List(IMediator _mediator)
        : EndpointWithoutRequest<CompetenceElementListResponse>
    {
        public override void Configure()
        {
            Get("/CompetenceElement");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var result = await _mediator.Send(new ListCompetenceElementQuery(), ct);

            if (result.IsSuccess)
            {
                Response = new CompetenceElementListResponse
                {
                    CompetenceElements = result.Value.Select(p => new CompetenceElementRecord(
                        p.Id,
                        p.Label,
                        0,
                        ""
                    )).ToList()
                };
            }

        }
    }
}

namespace SteelDonkey.UseCases.People.List
{
    public class ListPeopleHandler(IListPeopleQueryService _query)
        : IQueryHandler<ListPeopleQuery, Result<IEnumerable<PersonDto>>>
    {
        public async Task<Result<IEnumerable<PersonDto>>> Handle(ListPeopleQuery request, CancellationToken cancellationToken)
        {
            var result = await _query.ListAsync();

            return Result.Success(result);
        }
    }
}

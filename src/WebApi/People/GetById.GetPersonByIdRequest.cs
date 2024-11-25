namespace SteelDonkey.WebApi.People
{
    public class GetPersonByIdRequest
    {
        public const string Route = "/People/{PersonId:int}";
        public static string BuildRoute(int personId) => Route.Replace("{PersonId:int}", personId.ToString());

        public int PersonId { get; set; }
    }
}

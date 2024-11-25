namespace SteelDonkey.Core.Entities.People.Specifications
{
    public class PersonByIdSpec : Specification<Person>
    {
        public PersonByIdSpec(int personId) =>
            Query
                .Where(p => p.Id == personId);
    }
}

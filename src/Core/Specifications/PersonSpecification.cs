using Ardalis.Specification;
using SteelDonkey.Core.Entities.People;

namespace SteelDonkey.Core.Specifications
{
    public class PersonSpecification : Specification<Person>
    {
        public PersonSpecification(int personId)
        {
            Query
                .Where(x => x.Id == personId);
        }
    }
}

using Ardalis.Specification;
using Core.Entities.People;

namespace Core.Specifications
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

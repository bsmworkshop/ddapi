namespace SteelDonkey.Core.Exceptions
{
    public class PersonIsNotCurrentAssessorException : Exception
    {
        public PersonIsNotCurrentAssessorException()
            : base("Person does not have the required competence to carry out assessments, or it has expired.")
        {
        }

    }
}

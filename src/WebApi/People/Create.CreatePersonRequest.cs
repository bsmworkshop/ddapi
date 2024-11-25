using System.ComponentModel.DataAnnotations;

namespace SteelDonkey.WebApi.People
{
    public class CreatePersonRequest
    {
        public const string Route = "/People";

        [Required]
        public string? FamilyName { get;set; }
        [Required]
        public string? GivenName { get; set; }
        public string? OtherNames { get; set; }
    }
}

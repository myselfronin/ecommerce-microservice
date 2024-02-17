using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Services.Web.Models.Dto
{
    public class RegistrationRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Role {get;set;}
    }
}

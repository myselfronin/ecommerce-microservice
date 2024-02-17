using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Services.Web.Models.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

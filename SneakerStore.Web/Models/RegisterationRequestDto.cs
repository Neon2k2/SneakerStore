using System.ComponentModel.DataAnnotations;

namespace SneakerStore.Web.Models
{
    public class RegisterationRequestDto
    {
        [Required]
        public String Email { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }

        public string? Role {  get; set; }
    }
}

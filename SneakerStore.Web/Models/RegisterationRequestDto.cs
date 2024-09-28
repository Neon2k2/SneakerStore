namespace SneakerStore.Web.Models
{
    public class RegisterationRequestDto
    {
        public String Email { get; set; }
        public String Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public string? Role {  get; set; }
    }
}

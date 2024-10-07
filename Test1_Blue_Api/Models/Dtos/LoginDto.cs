using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models.Dtos
{
    public class LoginDto
    {
        [Required]
        public string userName {  get; set; }
        [Required]
        public string password { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Sabujcha.Areas.SabujchaAdminPanel.ViewModels
{
    public class UserCreateVM
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Username { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(3), MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MinLength(3), MaxLength(15)]
        public string FirstName { get; set; }
    }
}

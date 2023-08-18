using System.ComponentModel.DataAnnotations;

namespace Sabujcha.ViewModels
{
    public class LoginVM
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        [MinLength(8), MaxLength(15)]
        public string Password { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

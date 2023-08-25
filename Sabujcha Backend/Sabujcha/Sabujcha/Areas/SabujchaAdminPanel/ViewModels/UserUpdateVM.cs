using System.ComponentModel.DataAnnotations;

namespace Sabujcha.Areas.SabujchaAdminPanel.ViewModels
{
    public class UserUpdateVM
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        [MinLength(3), MaxLength(15)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3), MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MinLength(3), MaxLength(15)]
        public string LastName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}

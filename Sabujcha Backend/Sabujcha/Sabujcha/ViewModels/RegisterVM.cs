 using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;

namespace Sabujcha.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [MinLength(3),MaxLength(15)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3), MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MinLength(3), MaxLength(15)]
        public string LastName { get; set; } 
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        [MinLength(8), MaxLength(15)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
       public bool TermsConfirmed  { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;

namespace Sabujcha.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public bool TermsConfirmed { get; set; }


    }
}

using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Models
{
    public class User : IdentityUser
    {        
        public string Role { get; set; }
    }
}
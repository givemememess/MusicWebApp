using Microsoft.AspNetCore.Identity;

namespace MusicWebApplication.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}

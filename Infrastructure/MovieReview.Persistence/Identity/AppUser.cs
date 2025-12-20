using Microsoft.AspNetCore.Identity;

namespace MovieReview.Persistence.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string? ProfileImage { get; set; }
    }
}

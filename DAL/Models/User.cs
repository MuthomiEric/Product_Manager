using Microsoft.AspNetCore.Identity;

namespace Sokokapu_Stock_Management.Models
{
    public class User : IdentityUser
    {
        public string OfficeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

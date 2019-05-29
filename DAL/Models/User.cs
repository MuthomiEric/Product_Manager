using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sokokapu_Stock_Management.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}

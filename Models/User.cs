using Microsoft.AspNetCore.Identity;

namespace Identity_App.Models;

    public class User : IdentityUser
    {
        public User() : base() { }
        public DateTime DateOfBirth { get; set; } 
    }

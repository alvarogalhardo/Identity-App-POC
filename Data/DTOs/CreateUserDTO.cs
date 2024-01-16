using System.ComponentModel.DataAnnotations;

namespace Identity_App.Data.DTOs;
    public class CreateUserDTO
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
         public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }


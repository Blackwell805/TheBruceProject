using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RememberBruce.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MinLength(2, ErrorMessage = "First Name must be 2 characters or longer!")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name!")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "Last Name must be 2 characters or longer!")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name!")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter your email!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [RegularExpression(pattern: @"^(?=.*\d)(?=.*[a-z])(?=.*\W).{8,}$", ErrorMessage = "Invalid Password: Must contain at least one digit, one letter, and one special character.")]
        [Required(ErrorMessage = "Please enter a password!")]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password", ErrorMessage = "Confirm Password and Password do not match!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
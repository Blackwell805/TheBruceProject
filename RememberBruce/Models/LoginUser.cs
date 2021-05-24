using System.ComponentModel.DataAnnotations;

namespace RememberBruce.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    }
}
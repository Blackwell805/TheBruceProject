using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RememberBruce.Models
{
    [NotMapped]///DON'T ADD TO DATABASE\\\
    public class LoginUser
    {
        //////////LOGGED IN USER'S EMAIL\\\\\\\\\\\\
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string LoginEmail { get; set; }

        //////////LOGGED IN USER'S PASSWORD\\\\\\\\\\\\
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string LoginPassword { get; set; }
    }
}
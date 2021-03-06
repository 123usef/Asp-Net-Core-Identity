using System.ComponentModel.DataAnnotations;

namespace Asp_Net_Core_Identity.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password ) , ErrorMessage="Password and confirmation Password didn't match ")]
        public String ConfirmPassword { get; set; }

    }
}

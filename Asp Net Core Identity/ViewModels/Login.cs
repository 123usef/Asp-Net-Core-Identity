using System.ComponentModel.DataAnnotations;

namespace Asp_Net_Core_Identity.ViewModels
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email  { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public bool Remmemberme { get; set; }
    }
}

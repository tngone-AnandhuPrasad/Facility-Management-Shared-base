using System.ComponentModel.DataAnnotations;

namespace TNG.Shared.Lib.Models;
public class UserValidateRequest
{
       public UserValidateRequest(){}

        [Required(ErrorMessage = "Email cannot be null or empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be null or empty")]
        public string Password { get; set; }
}
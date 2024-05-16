using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class ForgetPasswordRequest
    {
        [Required(ErrorMessage = "Password cannot be null or empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword cannot be null or empty")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "UserId cannot be null or empty")]
        public string UserId { get; set; }
    }
}
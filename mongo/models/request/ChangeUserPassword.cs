using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class ChangeUserPasswordRequest
    {
        [Required(ErrorMessage = "Password cannot be null or empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword cannot be null or empty")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "OldPassword cannot be null or empty")]
        public string OldPassword { get; set; }
    }
}
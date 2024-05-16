using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class SignUpRequest
    {
        [Required(ErrorMessage = "Email cannot be null or empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "FullName cannot be null or empty")]
        public string FullName { get; set; }
        
}
}
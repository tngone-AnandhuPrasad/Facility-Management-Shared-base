using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class AddUsernameRequest
    {
        [Required(ErrorMessage = "FullName cannot be null or empty")]
        public string FullName { get; set; }
    }
}
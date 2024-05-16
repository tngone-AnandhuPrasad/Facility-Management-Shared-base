using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class EditAdminAccountRequest
    {
        [Required(ErrorMessage = "UserId cannot be null or empty")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Full name cannot be null or empty")]
        public string FullName { get; set; }
        public string Notes { get; set; }
        public string NickName { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class AcceptTermsRequest
    {
        [Required(ErrorMessage = "User cannot be null or empty")]
        public string UserId { get; set; }

    }
}
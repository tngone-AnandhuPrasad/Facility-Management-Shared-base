using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class UpdateAffiliatedLinkRequest
    {
        [Required(ErrorMessage = "Link cannot be null or empty")]
        public string Link { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class AddImageToSocialRequest
    {
        [Required(ErrorMessage = "Image hash cannot be null or empty")]
        public string ImageHash { get; set; }
        public string ImagePath { get; set; }
        public string ImageFileName { get; set; }
        public string ImageExtension { get; set; }
        [Required(ErrorMessage = "Session id cannot be null or empty")]
        public string SessionId { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetUserDetailsResponse
    {
        public string UserName { get; set; }
        public bool IsEnrolled { get; set; }
        public bool HasUnreadNotification { get; set; }
        public string SignUpType { get; set; }

    }
}
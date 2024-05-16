using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetNotificationResponse
    {
        public long Total { get; set; }
        public List<Notifications> Notifications { get; set; }

    }
    public class Notifications
    {
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
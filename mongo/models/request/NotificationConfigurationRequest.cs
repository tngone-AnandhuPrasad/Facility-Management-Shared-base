using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class NotificationConfigurationRequest
    {
        public string Days { get; set; }
    }
}
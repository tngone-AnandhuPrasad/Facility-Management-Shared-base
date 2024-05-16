using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetAdminSettingsResponse
    {
        public string Link { get; set; }
        public string PushNotification { get; set; }
        public string InAppNotification { get; set; }
        public DateTime? LinkLastUpdatedOn { get; set; }
        public DateTime? PushNotificationLastUpdatedOn { get; set; }
        public DateTime? InAppNotificationLastUpdatedOn { get; set; }
        public string LinkLastUpdatedBy { get; set; }
        public string PushNotificationLastUpdatedBy { get; set; }
        public string InAppNotificationLastUpdatedBy { get; set; }
    }
}
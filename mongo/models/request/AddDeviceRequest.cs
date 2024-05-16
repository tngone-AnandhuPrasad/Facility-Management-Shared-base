using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class AddDeviceRequest
    {
        [Required(ErrorMessage = "Device Id cannot be null or empty")]
        public string DeviceId { get; set; }

    }
}
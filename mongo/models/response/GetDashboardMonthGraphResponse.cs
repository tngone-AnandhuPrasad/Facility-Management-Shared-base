using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetDashboardMonthGraphResponse
    {
        public int Month { get; set; }
        public long Count { get; set; }

    }
}
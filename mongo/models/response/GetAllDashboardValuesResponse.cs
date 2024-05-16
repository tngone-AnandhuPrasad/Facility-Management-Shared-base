using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetAllDashboardValuesResponse
    {
        public long TotalUsers { get; set; }
        public long TotalRightSwipe { get; set; }
        public long TotalLeftSwipe { get; set; }
        public long TotalImagesShared { get; set; }
        public long TotalShares { get; set; }
        public long TotalAffiliatedUsers { get; set; }

    }
}
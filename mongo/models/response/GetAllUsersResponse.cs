using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetAllUsersResponse
    {
        public int Total { get; set; }
        public List<UserList> Users { get; set; }

    }
    public class UserList
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public long RightSwipeCount { get; set; }
        public long LeftSwipeCount { get; set; }
        public long ShareCount { get; set; }
        public long TotalImagesShared { get; set; }
        public bool? IsActive { get; set; }
        public bool IsAffliliated { get; set; }

    }
}
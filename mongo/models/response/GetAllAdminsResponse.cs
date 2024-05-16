using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetAllAdminsResponse
    {
        public int Total { get; set; }
        public List<AdminList> Admins { get; set; }

    }
    public class AdminList
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Notes { get; set; }
        public string NickName { get; set; }
        public DateTime? LastLogIn { get; set; }
        public bool? IsActive { get; set; }
    }
}
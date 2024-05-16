using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Models.Auth;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class SignUpResponse
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public string UserType { get; set; }
        public bool IsEmailVerified { get; set; }
        public string Username { get; set; }
        public bool IsTermsAccepted { get; set; }
        public bool HasNameAdded { get; set; }
    }
}
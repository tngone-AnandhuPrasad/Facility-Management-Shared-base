using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class LookUpResponse
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetTrashedImagesResponse
    {
        public List<TrashedImage> Images { get; set; }
        public long TotalImages { get; set; }

    }
    public class TrashedImage
    {
        public string ImageHash { get; set; }
        public string ImagePath { get; set; }
        public string ImageFileName { get; set; }
        public string ImageExtension { get; set; }
        public bool IsFromSocial { get; set; }
        public bool IsPermanentlyDeleted { get; set; }
    }
}
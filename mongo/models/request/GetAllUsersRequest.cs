using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class GetAllUsersRequest
    {
        [Required(ErrorMessage = "Rows per page cannot be null or empty")]
        public int RowsPerPage { get; set; }
        [Required(ErrorMessage = "Page number cannot be null or empty")]
        public int PageNumber { get; set; }

    }
}
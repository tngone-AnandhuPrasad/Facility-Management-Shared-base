using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;
using TNG.Shared.Lib.Mongo.Models;

namespace TNG.Shared.Lib.Mongo.Models
{
       public class GetUserResponse
    {
        public string Username { get; set; }
       
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Location { get; set; }
        public string UserType { get; set; }
        
       
       
        
       
    }

}

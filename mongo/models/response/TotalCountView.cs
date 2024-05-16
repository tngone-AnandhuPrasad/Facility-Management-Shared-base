using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;
using TNG.Shared.Lib.Mongo.Models;

namespace TNG.Shared.Lib.Mongo.Models
{
       public class TotalCountView
    {
        public int TotalUser{get;set;}
        public int TotalClient{get;set;}
        public int TotalAdmin{get;set;}
        public int TotalTask{get;set;}
        public int PendingTask{get;set;}

        public int CompletedTask{get;set;}

        
       
       
        
       
    }

}

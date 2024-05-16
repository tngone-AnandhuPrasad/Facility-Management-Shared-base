using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_RunnerLog : TNGMongoBase
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long FetchedRecords { get; set; }
        public string RunnerType { get; set; }

    }

}

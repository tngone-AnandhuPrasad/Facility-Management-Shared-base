using TNG.Shared.Lib.Mongo.Base;
namespace TNG.Shared.Lib.Mongo.Models
{

    public class MDBL_TASk : TNGMongoBase
    {
        public string TaskId { get; set; }

        public string Concept { get; set; }

        public string Location { get; set; }

        public string Persontocontact { get; set; }

        public string Responsibility { get; set; }
        public string Priority { get; set; }

        public string Status { get; set; }

        public DateOnly ConcernRaisedDate { get; set; }

        public TimeOnly RaisedTime { get; set; }

        public string Aging { get; set; }


        public string ActionPlan { get; set; }


        public DateOnly ApprovedQuotationDate { get; set; }

        public string remarks { get; set; }

        public string MaintainenceWork { get; set; }

    }
}



#region Assembly shared-lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\AnandhuPrasad\Documents\Facility-Management\shared-lib\obj\Debug\net8.0\ref\shared-lib.dll
#endregion

namespace TNG.Shared.Lib.Mongo.Models
{

  public class TaskView
  {
    public TaskView(){}

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

   

    public string MaintainenceWork { get; set; }

  }
}

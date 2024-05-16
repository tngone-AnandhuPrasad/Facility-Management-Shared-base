#region Assembly shared-lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\AnandhuPrasad\Documents\Facility-Management\shared-lib\obj\Debug\net8.0\ref\shared-lib.dll
#endregion

namespace TNG.Shared.Lib.Mongo.Models
{

  public class TaskDetails
  {
    public TaskDetails(){}

    public string taskcount{get;set;}

    public List<TaskView> TaskList{get;set;}
  }
  }
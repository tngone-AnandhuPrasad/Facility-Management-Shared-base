using TNG.Shared.Lib.Mongo.Base;
namespace TNG.Shared.Lib.Mongo.Models
{

  public class DateLocationSeacrhrequest
  {

    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }

    public string Location { get; set; }

  }
}



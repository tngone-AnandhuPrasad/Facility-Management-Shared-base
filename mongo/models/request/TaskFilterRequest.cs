using TNG.Shared.Lib.Mongo.Base;
using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models{
public class TaskFilterRequest{

    public DateTime FromDate{get;set;}
    public DateTime ToDate{get;set;}

    public string Concept{get;set;}
    public string Location{get;set;}

    public string PersontoContact{get;set;}

    public string Responsibility{get;set;}

    public string Status{get;set;}

    public string Priority{get;set;}




}
}
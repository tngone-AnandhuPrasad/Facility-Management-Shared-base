using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;
namespace TNG.Shared.Lib.Mongo.Models;

public class Edituserprofilerequest{

    public Edituserprofilerequest(){}
    
    [Required (ErrorMessage = "UserId is Required")]
    public  string UserID{get;set;}
    public  string Name{get;set;}

    public  string PhoneNumber{get;set;}

    

    public  string Location {get;set;}


}
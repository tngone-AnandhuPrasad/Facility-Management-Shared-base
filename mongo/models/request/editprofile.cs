using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;
namespace TNG.Shared.Lib.Mongo.Models;

public class Editprofilerequest{

    
    
    public  string Name{get;set;}

    public  string PhoneNumber{get;set;}
}
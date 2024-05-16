
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
public class Mailresponse
{
    public bool IsSuccess { get; set; }
    public string Error { get; set; }
    public string UserId { get; set; }
}}
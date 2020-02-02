using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace PokerPlamApi.Models
{
  public class User
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    [JsonProperty("Name")]
    public string UserName { get; set; }
    
    [BsonElement("Nick")]
    [JsonProperty("Nick")]
    public string NickName { get; set; }

    public string Password { get; set; }

    public string Mail { get; set; }
  }
}
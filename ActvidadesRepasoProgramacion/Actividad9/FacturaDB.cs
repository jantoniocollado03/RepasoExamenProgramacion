using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Actividad9;

public class FacturaDB
{
    [BsonId]
    public ObjectId _id { get; set; }
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Total { get; set; }
}
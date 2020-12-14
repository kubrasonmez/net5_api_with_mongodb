using MongoDB.Bson;

namespace Api.Core.Model
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}
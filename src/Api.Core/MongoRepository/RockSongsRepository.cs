using Api.Core.Model;

namespace Api.Core.MongoRepository
{
    public class RockSongsRepository : BaseMongoRepository<RockSongs>
    {
        public RockSongsRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {

        }
    }
}
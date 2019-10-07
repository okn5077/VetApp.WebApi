using VetApp.Model;

namespace VetApp.Services.Services.MongoRepository
{

    public class PetRepository : BaseMongoRepository<Pet>
    {
        public PetRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}

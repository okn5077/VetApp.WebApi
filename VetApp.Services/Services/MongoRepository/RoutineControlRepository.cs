using System;
using System.Collections.Generic;
using System.Text;
using VetApp.Model;

namespace VetApp.Services.Services.MongoRepository
{
    public class RoutineControlRepository : BaseMongoRepository<RoutineControl>
    {
        public RoutineControlRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}

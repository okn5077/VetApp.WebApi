using System;
using System.Collections.Generic;
using System.Text;
using VetApp.Model;

namespace VetApp.Services.Services.MongoRepository
{
    public class VaccineRepository : BaseMongoRepository<Vaccine>
    {
        public VaccineRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetApp.Model;

namespace VetApp.Services.Services.MongoRepository
{
    public class CustomerRepository : BaseMongoRepository<Customer>
    {
        public CustomerRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}

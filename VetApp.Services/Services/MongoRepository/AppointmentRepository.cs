using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetApp.Model;

namespace VetApp.Services.Services.MongoRepository
{
    public class AppointmentRepository : BaseMongoRepository<Appointment>
    {
        public AppointmentRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}

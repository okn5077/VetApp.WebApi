using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace VetApp.Model
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}

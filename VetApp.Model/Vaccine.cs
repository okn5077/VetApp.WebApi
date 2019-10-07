using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace VetApp.Model
{
    public class Vaccine : MongoBaseModel
    {
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Description { get; set; }

    }
}

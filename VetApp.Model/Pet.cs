using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace VetApp.Model
{
    public class Pet : MongoBaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Gender")]
        public bool Gender { get; set; }

        [BsonElement("Customer_Id")]
        public string Customer_Id { get; set; }
    }
}

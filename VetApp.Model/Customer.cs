using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace VetApp.Model
{
    public class Customer : MongoBaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("SurName")]
        public string SurName { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("MobilePhone")]
        public string MobilePhone { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Gender")]
        public bool Gender { get; set; }

        [BsonElement("Pets")]
        public List<string> Pets { get; set; }
    }
}

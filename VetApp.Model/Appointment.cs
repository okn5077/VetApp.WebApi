using MongoDB.Bson.Serialization.Attributes;
using System;
using VetApp.Model.Enums;

namespace VetApp.Model
{
    public class Appointment : MongoBaseModel
    {
        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("PlannedDate")]
        public DateTime PlannedDate { get; set; }
        [BsonElement("OccuringDate")]
        public DateTime OccuringDate { get; set; }
        [BsonElement("Pet")]
        public string Pet { get; set; }
        [BsonElement("Type")]
        public AppointmentType Type { get; set; }
        [BsonElement("TypeId")]
        public string TypeId { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product.Entities
{
   public class Location
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("latitude")]
        public double Latitude { get; set; }

        [BsonElement("longitude")]
        public double Longitude { get; set; }

    }
}

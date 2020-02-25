using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product.Entities
{
    public class Company
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("status")]
        public bool Status { get; set; }
        [BsonId]
        public ObjectId _Id { get; set; }
    }
}

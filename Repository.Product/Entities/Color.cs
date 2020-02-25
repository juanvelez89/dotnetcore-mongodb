using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product.Entities
{
    public class Color
    {
        [BsonElement("primaryColor")]
        public string PrimaryColor { get; set; }
        [BsonElement("secondColor")]
        public string SecondColor { get; set; }
    }
}

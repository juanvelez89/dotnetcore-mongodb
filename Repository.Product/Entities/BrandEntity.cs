using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product.Entities
{
    public class BrandEntity
    {
        private Color color;
        private Company company;

        [BsonId]
        public ObjectId _Id { get; set; }
        [BsonElement("logo")]
        public string Logo { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("status")]
        public bool Status { get; set; }

        [BsonElement("color")]
        public Color Color
        {
            get
            {
                if (color == null)
                {
                    return new Color();
                }
                return color;
            }

            set
            {
                color = value;
            }

        }

        [BsonElement("company")]
        public Company Company
        {
            get
            {
                if (company == null)
                {
                    return new Company();
                }
                return company;
            }
            set
            {
                company = value;
            }
        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product.Entities
{
    public class ProductEntity
    {
        private BrandEntity brand;
        private List<Location> locations;

        [BsonId]
        public ObjectId _Id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

        [BsonElement("brand")]
        public BrandEntity Brand
        {
            get
            {
                if (brand == null)
                {
                    return new BrandEntity();
                }
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        [BsonElement("locations")]
        public List<Location> Locations
        {
            get
            {
                if (locations == null)
                {
                    return new List<Location>();
                }
                return locations;
            }
            set { locations = value; }
        }


        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("status")]
        public bool Status { get; set; }
    }
}

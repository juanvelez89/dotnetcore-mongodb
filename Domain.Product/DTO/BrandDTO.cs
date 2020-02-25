using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.DTO
{
    public class BrandDTO
    {
        private ColorDTO color;
        private CompanyDTO company;

        public string _Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public ColorDTO Color
        {
            get
            {
                if (color == null)
                {
                    return new ColorDTO();
                }
                return color;
            }

            set
            {
                color = value;
            }

        }

        public CompanyDTO Company
        {
            get
            {
                if (company == null)
                {
                    return new CompanyDTO();
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.DTO.ResponseDTO
{
    public class HeaderDTO
    {
        public int ReponseCode { get; set; }
        public string Message { get; set; }

        public bool Success
        {
            get
            {
                if (ReponseCode >= 200 && ReponseCode < 300)
                {
                    return true;
                }

                return false;
            }
        }
    }
}

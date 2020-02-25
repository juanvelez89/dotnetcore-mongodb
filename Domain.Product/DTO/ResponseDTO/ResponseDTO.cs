using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.DTO.ResponseDTO
{
    public class ResponseDTO<T>
    {
        public HeaderDTO Header { get; set; }
        public T Data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.DTO.ResponseDTO
{
    public static class ResponseExtensionDTO
    {
        public static ResponseDTO<T> AsResponse<T>(this T result, int code, string message = "")
        {
            var response = new ResponseDTO<T>();
            response.Data = result;
            response.Header = new HeaderDTO() { ReponseCode = code, Message = message };
            return response;
        }
    }
}

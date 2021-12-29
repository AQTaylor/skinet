using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        

        public int StatusCode {get; set; }

        public string Message {get; set;}

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request has been made",
                401 => "You are not authorized to view this page",
                404 => "Resource not found",
                500 => "Cannot connect to server",
                _ => null
            };
        }
    }
}
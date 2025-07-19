using System.Net;

namespace App10.Api.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public List<string> Errors { get; set; } = new();
        public object? Result { get; set; }
    }
}

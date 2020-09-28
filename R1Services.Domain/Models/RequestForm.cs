using Microsoft.AspNetCore.Http;


namespace R1Services.Domain.Models
{
    public class RequestForm
    {
        public string Sender { get; set; }

        public IFormFile File { get; set; }
    }
}
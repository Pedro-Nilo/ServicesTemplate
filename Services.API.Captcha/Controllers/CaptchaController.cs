using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Domain.Interfaces.Services;

namespace Services.Application.Captcha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaptchaController : ControllerBase
    {
        private readonly IServiceCaptcha _serviceCaptcha;

        public CaptchaController(IServiceCaptcha serviceCaptcha)
        {
            _serviceCaptcha = serviceCaptcha ?? throw new ArgumentNullException(nameof(serviceCaptcha));
        }


        [HttpGet]
        public IActionResult LivenessListener()
        {
            return Ok("Captcha Service is ready!");
        }

        [HttpPost]
        [Route("request")]
        public async Task<IActionResult> CaptchaRequest(IFormCollection formCollection)
        {
            var jsonString = JsonSerializer.Serialize(formCollection);
            var responseData = await _serviceCaptcha.Request(formCollection);

            return Ok(responseData);
        }
    }
}
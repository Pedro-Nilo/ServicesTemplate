using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R1Services.Domain.Interfaces.Services;
using R1Services.Domain.Models;


namespace R1Services.Application.Captcha.Controllers
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
            return Ok("Captcha Service is read!");
        }

        [HttpPost]
        [Route("[controller]/request")]
        public async Task<IActionResult> CaptchaRequest(RequestForm requestForm)
        {
            var responseData = await _serviceCaptcha.Request(requestForm);

            return Ok(responseData);
        }
    }
}
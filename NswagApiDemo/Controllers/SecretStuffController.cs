using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NswagApiDemo.Controllers
{
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [Route("api/[controller]")]
    [ApiController]
    public class SecretStuffController : ControllerBase
    {
        private readonly ILogger<SecretStuffController> _logger;

        public SecretStuffController(ILogger<SecretStuffController> logger)
        {
            _logger = logger;
        }
        
        
        /// <summary>
        /// FASFADSFASDFDS
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        public IActionResult Get()
        {
            var correlationId = HttpContext.Request.Headers["CorrelationId"];
            

            return Ok(new { Secret = $"This is my secret." +
                $"You entered correlationId: {correlationId}"});
        }
    }
}

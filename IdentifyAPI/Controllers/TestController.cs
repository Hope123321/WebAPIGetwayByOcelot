using Microsoft.AspNetCore.Mvc;

namespace IdentifyAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "You using IdentifyAPI!";
        }
    }
}

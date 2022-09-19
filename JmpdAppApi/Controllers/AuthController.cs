using JmpdAppApi.Common.Dto;
using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JmpdAppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<AuthController> _logger;
        private readonly IAuthRepository authRepository;

        public AuthController(ILogger<AuthController> logger, IAuthRepository authRepository)
        {
            _logger = logger;
            this.authRepository = authRepository;
        }

        [HttpPost(Name = "SignIn")]
        public IActionResult SignIn(string username, string password)
        {
            //addlogging
            this.authRepository.GetUser(new off);
            return Ok();
        }
    }
}
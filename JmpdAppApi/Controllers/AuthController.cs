using JmpdAppApi.Common.Dto;
using JmpdAppApi.Core.Services.IServices;
using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JmpdAppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthenticationService authenticationService;

        public AuthController(ILogger<AuthController> logger, IAuthenticationService authenticationService)
        {
            _logger = logger;
            this.authenticationService = authenticationService;
        }

        [HttpPost(Name = "SignIn")]
        public IActionResult SignIn(string username, string password)
        {
            //addlogging
            return Ok(this.authenticationService.SignIn(new OfficialSignInDto
            {
                Username = username,
                Password = password
            }));
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotD_Edu.Api.Models;
using NajotD_Edu.Infrastructure.Abstractions;

namespace NajotD_Edu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginResult(LoginRequest request)
        {
            var token = await _authService.LoginAsync(request.UserName, request.Password);
            return Ok(token);
        }
    }
}

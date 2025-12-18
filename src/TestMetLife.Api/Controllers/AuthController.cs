using Microsoft.AspNetCore.Mvc;
using TestMetLife.Api.Models;
using TestMetLife.Application.Interfaces;

namespace TestMetLife.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthService _authService;

    public AuthController(IConfiguration configuration, IAuthService authService)
    {
        _configuration = configuration;
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var token = _authService.Authenticate(
            request.Username,
            request.Password
        );

        if (token is null)
            return Unauthorized();

        return Ok(new { token });
    }
}
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Moq;
using TestMetLife.Application.Services;

namespace TestMetLife.Application.Tests.Auth;

public class AuthServiceTests
{
    private readonly AuthService _authService;
    
    public AuthServiceTests()
    {
        var inMemorySettings = new Dictionary<string, string?>
        {
            { "Jwt:Key", "super-secret-key-for-tests-1234567890" },
            { "Jwt:Issuer", "TestIssuer" },
            { "Jwt:Audience", "TestAudience" },
            { "Jwt:ExpiresInMinutes", "60" }
        };

        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        _authService = new AuthService(configuration);     
    }

    [Fact]
    public void Login_WithValidCredentials_ReturnsToken()
    {
        // Arrange
        var user = "admin";
        var password = "password";

        // Act
        var result = _authService.Authenticate(user, password);

        // Assert
        result.Should().NotBeNullOrEmpty();
    }
    
    [Fact]
    public void Login_WithInvalidUser_ReturnsUnauthenticated()
    {
        // Arrange
        var user = "admini";
        var password = "password";

        // Act
        var result=  _authService.Authenticate(user, password);

        // Assert
        result.Should().BeNull();
    }
    
    [Fact]
    public void Login_WithInvalidPassword_ReturnsUnauthenticated()
    {
        // Arrange
        var user = "admin";
        var password = "passwordo";

        // Act
        var result=  _authService.Authenticate(user, password);

        // Assert
        result.Should().BeNull();
    }
}

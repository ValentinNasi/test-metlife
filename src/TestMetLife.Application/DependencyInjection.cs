using Microsoft.Extensions.DependencyInjection;
using TestMetLife.Application.Interfaces;
using TestMetLife.Application.Services;

namespace TestMetLife.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}
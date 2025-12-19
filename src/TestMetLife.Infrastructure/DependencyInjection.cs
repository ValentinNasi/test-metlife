using TestMetLife.Application.Interfaces;
using TestMetLife.Infrastructure.ExternalServices;
using TestMetLife.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace TestMetLife.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddHttpClient<JsonPlaceholderClient>(client =>
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
        });

        services.AddScoped<IPostService, PostService>();

        return services;
    }
}
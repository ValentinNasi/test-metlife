using TestMetLife.Application.DTOs;
using TestMetLife.Application.Interfaces;
using TestMetLife.Infrastructure.ExternalServices;

namespace TestMetLife.Infrastructure.Services;

public class PostService : IPostService
{
    private readonly JsonPlaceholderClient _jsonPlaceholderClient;

    public PostService(JsonPlaceholderClient jsonPlaceholderClient)
    {
        _jsonPlaceholderClient = jsonPlaceholderClient;
    }

    public Task<IEnumerable<PostDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PostDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
using System.Net.Http.Json;
using TestMetLife.Domain.Entities;

namespace TestMetLife.Infrastructure.ExternalServices;

public class JsonPlaceholderClient
{
    private readonly HttpClient _httpClient;

    public JsonPlaceholderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<Post>> GetPostsAsync()
    {
        return await _httpClient
                   .GetFromJsonAsync<IEnumerable<Post>>("/posts")
               ?? Enumerable.Empty<Post>();
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _httpClient
            .GetFromJsonAsync<Post>($"/posts/{id}");
    }
}
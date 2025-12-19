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

    public async Task<IEnumerable<PostDto>> GetAllAsync()
    {
        var posts = await _jsonPlaceholderClient.GetPostsAsync();
        
        return posts.Select(p => new PostDto
        {
            Id = p.Id,
            UserId = p.UserId,
            Title = p.Title,
            Body = p.Body
        });
    }

    public async Task<PostDto?> GetByIdAsync(int id)
    {
        var post = await _jsonPlaceholderClient.GetPostByIdAsync(id);
        if(post == null) 
            return null;
        
        return new PostDto
        {
            Id = post.Id,
            UserId = post.UserId,
            Title = post.Title,
            Body = post.Body
        };
    }
}
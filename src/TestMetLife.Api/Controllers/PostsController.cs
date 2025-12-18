using Microsoft.AspNetCore.Mvc;
using TestMetLife.Application.Interfaces;

namespace TestMetLife.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly IPostService _postService;

    public PostsController(IPostService postService)
    {
        _postService = postService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var posts = await _postService.GetAllAsync();
        return Ok(posts);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var post = await _postService.GetByIdAsync(id);

        if (post == null)
            return NotFound();

        return Ok(post);
    }
}
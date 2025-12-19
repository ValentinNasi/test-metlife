using TestMetLife.Application.DTOs;

namespace TestMetLife.Application.Interfaces;

public interface IPostService
{
    Task<IEnumerable<PostDto>> GetAllAsync();
    Task<PostDto?> GetByIdAsync(int id);
}
using TaskManagement.BL.DTOs.TagDTOs;

namespace TaskManagement.BL.Services.Abstracts;

public interface ITagService
{
    Task<List<TagListItem>> GetAllAsync();
    Task<int> CreateAsync(TagCreateDTO dto);
    Task Delete(int id);
}

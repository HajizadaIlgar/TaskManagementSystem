using TaskManagement.BL.DTOs.TopicDTOs;

namespace TaskManagement.BL.Services.Abstracts;

public interface ITopicService
{
    Task<List<TopicListItem>> GetAllAsync();
    Task<int> CreateAsync(TopicCreateDTO dto);
    Task Delete(int id);
}

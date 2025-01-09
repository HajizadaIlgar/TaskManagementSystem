using Microsoft.EntityFrameworkCore;
using TaskManagement.BL.DTOs.TopicDTOs;
using TaskManagement.BL.Services.Abstracts;
using TaskManagement.CORE.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Services.Implements
{
    public class TopicService(ITopicRepository _repo) : ITopicService
    {
        public async Task<int> CreateAsync(TopicCreateDTO dto)
        {
            Topic topic = dto;
            await _repo.AddAsync(dto);
            await _repo.SaveAsync();
            return topic.Id;
        }

        public async Task Delete(int id)
        {
            var data = await _repo.GetAll().Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null)
                throw new Exception();
            _repo.Delete(data);
            await _repo.SaveAsync();
        }

        public async Task<List<TopicListItem>> GetAllAsync()
        {
            return await _repo.GetAll().Select(x => new TopicListItem
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TaskManagement.BL.DTOs.TagDTOs;
using TaskManagement.BL.Services.Abstracts;
using TaskManagement.CORE.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Services.Implements
{
    public class TagService(ITagRepository _repo) : ITagService
    {
        public async Task<int> CreateAsync(TagCreateDTO dto)
        {
            Tag tag = dto;
            await _repo.AddAsync(dto);
            await _repo.SaveAsync();
            return tag.Id;
        }

        public async Task Delete(int id)
        {
            var data = await _repo.GetAll().Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null)
                throw new Exception();
            _repo.Delete(data);
            await _repo.SaveAsync();
        }

        public async Task<List<TagListItem>> GetAllAsync()
        {
            return await _repo.GetAll().Select(x => new TagListItem
            {
                Id = x.Id,
                Name = x.Name,
                Urgent = x.Urgent,
                UntilTomorrow = x.UntilTomorrow,
                ItIsNotImportant = x.ItIsNotImportant,
            }).ToListAsync();
        }

    }
}

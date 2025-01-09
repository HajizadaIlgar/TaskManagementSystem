using AutoMapper;
using TaskManagement.BL.DTOs.TagDTOs;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Mappers
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<TagCreateDTO, Tag>().ReverseMap();

        }
    }
}

using AutoMapper;
using TaskManagement.BL.DTOs.TopicDTOs;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Mappers
{
    public class TopicProfile : Profile
    {
        public TopicProfile()
        {
            CreateMap<Topic, TopicListItem>().ReverseMap();
        }
    }
}

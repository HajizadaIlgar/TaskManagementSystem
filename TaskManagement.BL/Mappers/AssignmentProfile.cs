using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.DTOs;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Mappers
{
    public class AssignmentProfile:Profile
    {
        public AssignmentProfile()
        {
            CreateMap<AssignmentCreateDTO, Assignment>().ReverseMap();
            CreateMap<Assignment,AssignmentListItem>().ReverseMap();
        }
    }
}

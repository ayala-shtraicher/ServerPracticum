using AutoMapper;
using PracticumProject.common.DTO;
using PracticumProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<ChildUser, ChildUserDTO>().ReverseMap();
        }
    }
}

using AutoMapper;
using Identity_App.Data.DTOs;
using Identity_App.Models;

namespace Identity_App.Profiles;

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDTO, User>();
        }
    }


using AutoMapper;
using Domain.DTOs.ApplicationUser;
using Domain.DTOs.Board;
using Domain.DTOs.List;
using Domain.DTOs.Subtask;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings {
    public class EntityToDtoProfile : Profile {
        public EntityToDtoProfile() {
            CreateMap<ListAddDto, ListEntity>()
                .ReverseMap();
            CreateMap<ListUpdateDto, ListEntity>()
                .ReverseMap();
            CreateMap<ListDto, ListEntity>()
                .ReverseMap();

            CreateMap<BoardAddDto, BoardEntity>()
                .ReverseMap();
            CreateMap<BoardUpdateDto, BoardEntity>()
                .ReverseMap();
            CreateMap<BoardDto, BoardEntity>()
                .ReverseMap();

            CreateMap<ApplicationUserAddDto, ApplicationUserEntity>()
                .ReverseMap();
            CreateMap<ApplicationUserUpdateDto, ApplicationUserEntity>()
                .ReverseMap();
            CreateMap<ApplicationUserDto, ApplicationUserEntity>()
                .ReverseMap();

            CreateMap<SubtaskAddDto, SubtaskEntity>()
                .ReverseMap();
            CreateMap<SubtaskUpdateDto, SubtaskEntity>()
                .ReverseMap();
            CreateMap<SubtaskDto, SubtaskEntity>()
                .ReverseMap();
        }
    }
}

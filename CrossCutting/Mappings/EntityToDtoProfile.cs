﻿using AutoMapper;
using Domain.DTOs.Board;
using Domain.DTOs.List;
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
        }
    }
}
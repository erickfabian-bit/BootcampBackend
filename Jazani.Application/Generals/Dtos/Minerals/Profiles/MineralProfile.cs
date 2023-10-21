using AutoMapper;
using Jazani.Domain.Generals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Dtos.Minerals.Profiles
{
    public class MineralProfile : Profile
    {
        public MineralProfile() 
        {
            CreateMap<Mineral, MineralDto>();

            CreateMap<Mineral, MineralSaveDto>().ReverseMap();
        }
    }
}

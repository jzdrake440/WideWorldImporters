using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WideWorldImporters.BLL.Models;
using WideWorldImporters.Model.Dto;

namespace WideWorldImporters.AutoMapper
{
    public class PresentationLayerProfile : Profile
    {
        public PresentationLayerProfile()
        {
            CreateMap<PersonDto, PersonBl>();
            CreateMap<PersonDetailDto, PersonBl>();
        }
    }
}

using AutoMapper;
using IKProject.Application.DTOs;
using IKProject.Core.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IKProject.Application.Mappers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Yonetici, YoneticiDTO>().ReverseMap();
        }
    }
}

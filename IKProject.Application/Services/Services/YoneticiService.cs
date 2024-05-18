using AutoMapper;
using IKProject.Application.DTOs;
using IKProject.Application.Services.IServices;
using IKProject.Application.Utilities.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.Services.Services
{
    public class YoneticiService:IYoneticiService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public YoneticiService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<YoneticiDTO>> GetAllYoneticilerAsync()
        {
            var yoneticiler = await unitOfWork.YoneticiRepo.GetAllAsync();
            return mapper.Map<IEnumerable<YoneticiDTO>>(yoneticiler);
        }
    }
}

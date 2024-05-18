using AutoMapper;
using IKProject.Application.Services.IServices;
using IKProject.Application.Services.Services;
using IKProject.Application.Utilities.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Infrastructure.Utilities.UnitOfWorks
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UnitOfWorkService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            YoneticiService = new YoneticiService(_unitOfWork, _mapper);
        }
        public IYoneticiService YoneticiService { get;}
    }
}

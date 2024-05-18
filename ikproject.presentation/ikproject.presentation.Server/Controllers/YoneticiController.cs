using AutoMapper;
using IKProject.Application.DTOs;
using IKProject.Application.Services.Services;
using IKProject.Application.Utilities.IUnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ikproject.presentation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoneticiController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        private readonly IMapper mapper;

        public YoneticiController(IUnitOfWorkService unitOfWorkService, IMapper mapper)
        {
            _unitOfWorkService = unitOfWorkService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllYoneticiler")]
        public async Task<ActionResult<IEnumerable<YoneticiDTO>>> GetAllYoneticiler() 
        { 
            var yoneticiler = await _unitOfWorkService.YoneticiService.GetAllYoneticilerAsync();
            return Ok(yoneticiler); 
        }
    }
}

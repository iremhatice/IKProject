using IKProject.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.Services.IServices
{
    public interface IYoneticiService
    {
        Task<IEnumerable<YoneticiDTO>> GetAllYoneticilerAsync();
    }
}

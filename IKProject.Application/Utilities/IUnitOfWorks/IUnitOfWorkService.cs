using IKProject.Application.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.Utilities.IUnitOfWorks
{
    public interface IUnitOfWorkService
    {
        public IYoneticiService YoneticiService { get; }
    }
}

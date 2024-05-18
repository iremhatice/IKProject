using IKProject.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.Utilities.IUnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        IYoneticiRepo YoneticiRepo { get; }
    }
}

using IKProject.Application.IRepositories;
using IKProject.Application.Utilities.IUnitOfWorks;
using IKProject.Infrastructure.Contexts;
using IKProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Infrastructure.Utilities.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IKContext _context;
        public UnitOfWork(IKContext context)
        {
            this._context = context;
            YoneticiRepo = new YoneticiRepo(_context);
        }

        public IYoneticiRepo YoneticiRepo { get; }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

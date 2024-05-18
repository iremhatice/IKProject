using IKProject.Application.IRepositories;
using IKProject.Core.DomainModels.Models;
using IKProject.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Infrastructure.Repositories
{
    public class YoneticiRepo : BaseRepo<Yonetici>, IYoneticiRepo
    {
        public YoneticiRepo(IKContext context) : base(context)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.BaseModels
{
    public abstract class BaseEntity:IBaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}

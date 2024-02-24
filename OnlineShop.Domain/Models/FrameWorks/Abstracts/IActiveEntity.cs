using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.FrameWorks.Abstracts
{
    public interface IActiveEntity
    {
        public bool IsActive { get; set; }
    }
}

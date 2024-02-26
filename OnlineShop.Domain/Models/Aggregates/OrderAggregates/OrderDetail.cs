using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.OrderAggregates
{
    public class OrderDetail : BaseEntity
    {
        //public Guid OrderHeaderId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public List<OrderHeader> OrderHeaders { get; } = [];
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.OrderAggregates
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderHeaderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public OrderHeader? OrderHeader { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.OrderAggregates
{
    public class OrderDetail
    {
        //public Guid OrderHeaderId { get; set; }

        // Foreign key property
        public Guid ProductId { get; set; }
        // Navigation property
        public Product Product { get; set; }

        // Foreign key property
        public Guid OrderHeaderId { get; set; }
        // Navigation property
        public OrderHeader OrderHeader { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        //public List<OrderHeader> OrderHeaders { get; } = [];
    }
}

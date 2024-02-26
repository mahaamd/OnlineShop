using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.Aggregates.OrderAggregates
{
    public class OrderHeaderOrderDetail:BaseEntity
    {
        public OrderHeader OrderHeader { get; set;}
        public OrderDetail OrderDetail { get; set;}
    }
}

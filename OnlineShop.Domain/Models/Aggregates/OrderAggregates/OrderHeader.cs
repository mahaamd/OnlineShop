using Microsoft.AspNetCore.Identity;
using OnlineShop.Domain.Models.FrameWorks.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.Aggregates.OrderAggregates
{
    public class OrderHeader : BaseEntity
    {
        public string? Code { get; set; }
        public DateTime? Date { get; set; }
        public string? Seller { get; set; }
        public string? Buyer { get; set; }
        public List<OrderDetail> OrderDetails { get; } = [];


    }
}

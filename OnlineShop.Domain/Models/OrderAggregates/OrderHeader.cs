using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.OrderAggregates
{
    public class OrderHeader : BaseEntity
    {
        public string? Code { get; set; }
        public DateTime? Date { get; set; }
        public string? Seller { get; set; }
        public string? Buyer { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}

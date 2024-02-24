using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.ProductAggregates
{
    public class ProductCategory : BaseEntity
    {
        Guid ProductId { get; set; }
        public string? Title { get; set;}
    }
}

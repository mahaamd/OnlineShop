using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.ProductAggregates
{
    public class ProductCategory : BaseEntity
    {
        Product? ProductId { get; set; }
        public string? Title { get; set; }

        ProductCategory? productCategory { get; set; }
    }
}

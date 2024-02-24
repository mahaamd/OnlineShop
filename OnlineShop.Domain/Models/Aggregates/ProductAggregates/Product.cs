using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.ProductAggregates
{
    public class Product : BaseEntity
    {
        public Guid ProductCategoryId { get; set; }
        public string? Title { get; set; }
        public string Code { get; set; }
        public decimal unitPrice { get; set; }

    }
}

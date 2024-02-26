using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.FrameWorks.Base;

namespace OnlineShop.Domain.Models.Aggregates.ProductAggregates
{
    public class ProductCategory : BaseEntity
    {
        //public Product? ProductId { get; set; }
        public string Title { get; set; }
        public ProductCategory? Parent { get; set; }
    }
}

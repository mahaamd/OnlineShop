using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.Models.Aggregates.OrderAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    internal class OrderHeaderOrderDetailConfiguration : IEntityTypeConfiguration<OrderHeaderOrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderHeaderOrderDetail> builder)
        {


        }
    }
}

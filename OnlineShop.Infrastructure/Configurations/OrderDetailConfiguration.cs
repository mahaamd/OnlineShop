using OnlineShop.Domain.Models.Aggregates.OrderAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            //builder.HasKey(orderDetail => new { orderDetail.Product, orderDetail.OrderHeader });
            builder.Property(orderDetail => orderDetail.Quantity).IsRequired();
            builder.Property(orderDetail => orderDetail.UnitPrice).IsRequired();
        }
    }
}
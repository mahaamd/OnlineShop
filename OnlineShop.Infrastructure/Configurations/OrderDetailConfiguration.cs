using OnlineShop.Domain.Models.Aggregates.OrderAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(orderDetail => new { orderDetail.ProductId, orderDetail.OrderHeaderId });
            builder.HasOne(orderDetail => orderDetail.Product)
                   .WithMany()
                   .HasForeignKey(orderDetail => orderDetail.ProductId);

            builder.HasOne(orderDetail => orderDetail.OrderHeader)
                   .WithMany(orderHeader => orderHeader.OrderDetails)
                   .HasForeignKey(orderDetail => orderDetail.OrderHeaderId);
        }
    }
}
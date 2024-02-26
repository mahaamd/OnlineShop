
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.Models.Aggregates.OrderAggregates;

namespace BookStore.Infrastructure.Configurations
{
    public class OrderHeaderConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            builder.Property(orderHeader => orderHeader.Code).IsRequired();
            builder.Property(orderHeader => orderHeader.Date).HasDefaultValue(DateTime.Now);
        }
    }
}
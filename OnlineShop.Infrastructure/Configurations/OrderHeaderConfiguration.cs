using BookStore.Domain.Models.OrderAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
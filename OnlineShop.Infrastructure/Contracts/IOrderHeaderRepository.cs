using OnlineShop.Domain.Models.Aggregates.OrderAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Contracts
{
    public interface IOrderHeaderRepository:ICompleteBaseRepository<OrderHeader>
    {
    }
}

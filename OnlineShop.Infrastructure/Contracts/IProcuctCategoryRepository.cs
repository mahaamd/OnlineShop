using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Contracts
{
    public interface IProcuctCategoryRepository:ICompleteBaseRepository<ProductCategory>
    {
    }
}

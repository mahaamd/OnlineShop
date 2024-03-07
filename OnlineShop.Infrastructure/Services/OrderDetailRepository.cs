using BookStore.Utility.ValidationErrors;
using OnlineShop.Domain.Models.Aggregates.OrderAggregates;
using OnlineShop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Services
{
    internal class OrderDetailRepository : IOrderDetailRepository
    {
        public Task<IEnumerable<ValidationError?>?> DeleteAsync(OrderDetail? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> DeleteByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertAsync(OrderDetail? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertRangeAsync(IEnumerable<OrderDetail?>? entities)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExist(OrderDetail? entity)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExistById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<OrderDetail?>?, IEnumerable<ValidationError?>?)> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(OrderDetail?, IEnumerable<ValidationError?>?)> SelectAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> UpdateAsync(OrderDetail? entity)
        {
            throw new NotImplementedException();
        }
    }
}

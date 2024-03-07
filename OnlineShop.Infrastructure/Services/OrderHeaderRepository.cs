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
    internal class OrderHeaderRepository : IOrderHeaderRepository
    {
        public Task<IEnumerable<ValidationError?>?> DeleteAsync(OrderHeader? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> DeleteByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertAsync(OrderHeader? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertRangeAsync(IEnumerable<OrderHeader?>? entities)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExist(OrderHeader? entity)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExistById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<OrderHeader?>?, IEnumerable<ValidationError?>?)> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(OrderHeader?, IEnumerable<ValidationError?>?)> SelectAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> UpdateAsync(OrderHeader? entity)
        {
            throw new NotImplementedException();
        }
    }
}

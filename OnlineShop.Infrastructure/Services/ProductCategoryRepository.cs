using BookStore.Utility.ValidationErrors;
using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Services
{
    internal class ProductCategoryRepository : IProcuctCategoryRepository
    {
        public Task<IEnumerable<ValidationError?>?> DeleteAsync(ProductCategory? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> DeleteByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertAsync(ProductCategory? entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> InsertRangeAsync(IEnumerable<ProductCategory?>? entities)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExist(ProductCategory? entity)
        {
            throw new NotImplementedException();
        }

        public Task<(bool, IEnumerable<ValidationError?>?)> IsExistById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<ProductCategory?>?, IEnumerable<ValidationError?>?)> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(ProductCategory?, IEnumerable<ValidationError?>?)> SelectAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValidationError?>?> UpdateAsync(ProductCategory? entity)
        {
            throw new NotImplementedException();
        }
    }
}

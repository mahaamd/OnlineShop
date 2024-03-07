using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Contracts
{
    public interface IBaseRepository<TEntity, TError, TId, TExist>
    {
        Task<IEnumerable<TError?>?> InsertAsync(TEntity? entity);
        Task<IEnumerable<TError?>?> InsertRangeAsync(IEnumerable<TEntity?>? entities);
        Task<IEnumerable<TError?>?> UpdateAsync(TEntity? entity);
        Task<IEnumerable<TError?>?> DeleteAsync(TEntity? entity);
        Task<IEnumerable<TError?>?> DeleteByIdAsync(TId? id);
        Task<(IEnumerable<TEntity?>?, IEnumerable<TError?>?)> SelectAllAsync();
        Task<(TEntity?, IEnumerable<TError?>?)> SelectAsync(TId? id);
        //Task<(TExist, IEnumerable<TError?>?)> IsExist(TEntity? entity);
        //Task<(TExist, IEnumerable<TError?>?)> IsExistById(TId? id);
    }
}

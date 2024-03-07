using BookStore.Utility.ValidationErrors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Contracts
{
    public interface ICompleteBaseRepository<TEntity> : IBaseRepository<TEntity, ValidationError, Guid?, bool> { }
}

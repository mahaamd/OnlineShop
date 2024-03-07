using BookStore.Utility.ValidationErrors;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Services
{
    public class ProductRepository : IproductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ValidationError?>?> DeleteAsync(Product? entity)
        {
            List<ValidationError?>? errors = new();

            if (entity == null)
            {
                errors.Add(new ValidationError { Code = "NullProductException", 
                    Description = "Product shouldn't be null" });
                return errors;
            }

            try
            {
                _context.Product.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                errors.Add(new ValidationError { Code = e.Message, Description = e.StackTrace });
            }

            return errors;
        }

        public async Task<IEnumerable<ValidationError?>?> DeleteByIdAsync(Guid? id)
        {
            List<ValidationError?>? errors = new();

            if (id == null)
            {
                errors.Add(new ValidationError { Code = "Invalid Id", Description="Id should not be null"});
                return errors;
            }

            var (product, selectErrors) = await SelectAsync(id);

            if (product == null)
            {
                if (selectErrors != null)
                    errors.AddRange(selectErrors);
                return errors;
            }

            try
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();

            } catch (Exception e)
            {
                errors.Add(new ValidationError
                {
                    Code = e.Message,
                    Description = e.StackTrace
                });
            }

            return errors;
        }

        public async Task<IEnumerable<ValidationError?>?> InsertAsync(Product? entity)
        {
            List<ValidationError?>? errors = new();

            if (entity == null)
            {
                errors.Add(new ValidationError {Code="null product",
                    Description="product can not be null"});
                return errors;

            }

            try
            {
                _context.Add(entity);
                await _context.SaveChangesAsync();
            } catch (Exception e) 
            {
                errors.Add(new ValidationError
                {
                    Code = e.Message,
                    Description = e.StackTrace
                });
            }

            return errors;
        }

        public async Task<IEnumerable<ValidationError?>?> InsertRangeAsync(IEnumerable<Product?>? entities)
        {
            List<ValidationError?>? errors = new();

            if (entities == null)
            {
                errors.Add(new ValidationError
                {
                    Code = "null product",
                    Description = "range of product you adding can not be null"
                });
                return errors;
            }

            List<Product> products = new List<Product>();

            foreach (var item in entities)
            {
                if (item == null)
                {
                    errors.Add(new ValidationError
                    {
                        Code = "null product",
                        Description = "product can not be null"
                    });
                }
                  else products.Add(item);
            }

            try
            {
                _context.Product.AddRangeAsync(products);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                errors.Add(new ValidationError
                {
                    Code = e.Message,
                    Description = e.StackTrace
                });
            }

            return errors;
        }

        //public Task<(bool, IEnumerable<ValidationError?>?)> IsExist(Product? entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<(bool, IEnumerable<ValidationError?>?)> IsExistById(Guid? id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<(IEnumerable<Product?>?, IEnumerable<ValidationError?>?)> SelectAllAsync()
        {
            List<ValidationError?>? errors = new();
            List<Product>? products = new();

            try
            {
                products = await _context.Product.ToListAsync();
                if (!products.Any())
                {
                    errors.Add(new ValidationError { Code = "NullProductFound", 
                        Description = "There are no product in the app" });
                }
            }
            catch (Exception e)
            {
                errors.Add(new ValidationError { Code = e.Message, 
                    Description = e.StackTrace });
            }

            return (products, errors);
        }

        public async Task<(Product?, IEnumerable<ValidationError?>?)> SelectAsync(Guid? id)
        {
            List<ValidationError?>? errors = new();
            Product? prouct = new();
            if (id == null)
            {
                errors.Add(new ValidationError { Code = "id is not valid", 
                    Description="there is no valid id here" });
            }
            try
            {
                prouct = await _context.Product.FirstOrDefaultAsync(p => p.Id == id);
                if (prouct == null) { 
                    errors.Add(new ValidationError { Code = "ProductNotFound",
                        
                     Description = "Product couldn't be found" });

                }

            } catch (Exception e)
            {
                errors.Add(new ValidationError
                {
                    Code = e.Message,
                    Description = e.StackTrace
                });
            }

            return (prouct, errors); ;
            
        }

        public async Task<IEnumerable<ValidationError?>?> UpdateAsync(Product? entity)
        {
            List<ValidationError?>? errors = new();
            Product? prouct = new();

            if (entity == null)
            {
                errors.Add(new ValidationError { Code="invalid entiry", 
                    Description="invalid entity have founded"});
                return errors;
            }
            prouct = await _context.Product.FirstOrDefaultAsync(item => item.Id == entity.Id);
            if (prouct == null)
            {
                errors.Add(new ValidationError
                {
                    Code = "invalid entiry",
                    Description = "invalid entity have founded"
                });
                return errors;
            }

            try
            {
                _context.Product.Update(entity);
                _context.SaveChanges();
            }catch (Exception e)
            {
                errors.Add(new ValidationError
                {
                    Code = e.Message,
                    Description = e.StackTrace
                });
            }
            return errors;
        }
    }
}

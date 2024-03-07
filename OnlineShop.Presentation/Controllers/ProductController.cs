using BookStore.Utility.ValidationErrors;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain.Models.Aggregates.ProductAggregates;
using OnlineShop.Infrastructure.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IproductRepository _productRepository;

        public ProductController(IproductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return Ok("Welcome to the ProductController");
        }

        #region [adding product]
        [HttpGet]
        public IActionResult Add()
        {
            return Ok("every thing is working");
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _productRepository.InsertAsync(product);
                return Ok(product);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
            #endregion
        }

        [HttpGet]
        public IActionResult Update()
        {
            return Ok("every thing is working in Update");
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Task<Product> p = await _productRepository.SelectAsync(product?.Id);

            try
            {
                Console.WriteLine("here in updating product");
                await _productRepository.UpdateAsync(product);
                return Ok(product);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return Ok("every thing is working in Update");
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] Product product)
        {
            Guid guid;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Task<Product> p = await _productRepository.SelectAsync(product?.Id);

            try
            {
                Console.WriteLine("here in updating product");
                _productRepository?.DeleteByIdAsync(product.Id);
                return Ok(product.Id);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
         var result = await _productRepository.SelectAllAsync();

         return Ok(result.Item1);

        }
    }
}

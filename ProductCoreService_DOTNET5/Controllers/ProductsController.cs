using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCoreService_DOTNET5.Models;

namespace ProductCoreService_DOTNET5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public ProductsController()
        {
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            HttpContext.Response.StatusCode = 200;
            return await Data.Products;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var products = await Data.Products;
            var product = products.FirstOrDefault(p => p.barcode == id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            // if (id != product.barcode) return BadRequest();
            var products = await Data.Products;

            if(!await ProductExists(id)) return NotFound();
            products.ForEach(p => {
                if (p.barcode == id)
                {
                    p.name = product.name;
                    p.price = product.price;
                    p.quantity = product.quantity;
                    p.discount = product.discount;
                    p.category = product.category;
                }
            });
            return NoContent(); // 204
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            HttpContext.Response.StatusCode = 201;
            var products = await Data.Products;
            products.Add(product);
            return  product;
        }

        // // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var products = await Data.Products;
            // delete product by barcode
            var product = products.FirstOrDefault(p => p.barcode == id);
            if (product == null)
            {
                return NotFound(); // 404
            }
            products.Remove(product );


            return NoContent(); // 204
        }

        private async Task<bool> ProductExists(int id)
        {
            var products = await Data.Products;
            return products.Any(e => e.barcode == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using UnitTestMoqFinal.Models;
using UnitTestMoqFinal.Services;

namespace UnitTestMoqFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("productlist")]
        public IEnumerable<Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;

        }
        [HttpGet("getproductbyid")]
        public Product GetProductById(int Id)
        {
            return productService.GetProductById(Id);
        }

        [HttpPost("addproduct")]
        public Product AddProduct(Product product)
        {
            return productService.AddProduct(product);
        }

        [HttpPut("updateproduct")]
        public Product UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }

        //[HttpDelete("deleteproduct")]
        //public bool DeleteProduct(int Id)
        //{
        //    return productService.DeleteProduct(Id);
        //}
    }
}

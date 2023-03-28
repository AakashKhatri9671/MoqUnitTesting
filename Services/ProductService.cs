using UnitTestMoqFinal.Data;
using UnitTestMoqFinal.Models;

namespace UnitTestMoqFinal.Services
{
    public class ProductService : IProductService
    {
        private readonly DbContextClass _context;

        public ProductService(DbContextClass context)
        {
            this._context = context;
        }
        public IEnumerable<Product> GetProductList()
        {
            var products = _context.Products.ToList();
            return products;
        }
        public Product AddProduct(Product product)
        {
            if (product != null)
            {
                var result = _context.Products.Add(product);
                _context.SaveChanges();
                return result.Entity;
            }

            return null;
        }

        public bool DeleteProduct(int Id)
        {
            var product = _context.Products.Find(Id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            var result = _context.Products.Update(product);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}

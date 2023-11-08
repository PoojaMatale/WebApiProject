using WebApiProject.Models;
using WebApiProject.Repository;

namespace WebApiProject.Sevice
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Product product)
        {
            return repo.AddProduct(product);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public object GetProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        public int UpdateProduct(Product product)
        {
            return repo.UpdateProduct(product);
        }
    }
}

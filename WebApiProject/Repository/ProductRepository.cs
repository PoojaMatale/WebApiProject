using WebApiProject.Data;
using WebApiProject.Models;

namespace WebApiProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        ApplicationdbContext db;
        public ProductRepository(ApplicationdbContext db) 
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int res = 0;
            var result = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Products.Remove(result); 
                res = db.SaveChanges();
            }

            return res;
        }

        public Product GetProductById(int id)
        {
            var result = db.Products.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public int UpdateProduct(Product product)
        {

            int res = 0;


            var result = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = product.Name; 
                result.price = product.price;
               
                res = db.SaveChanges();
            }

            return res;
        }
    }
}

﻿using WebApiProject.Models;

namespace WebApiProject.Sevice
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
        object GetProduct();
    }
}
using StoreAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace StoreAPI.Controllers
{
    public class ProductController : ApiController
    {
        List<ProductEntity1> products = new List<ProductEntity1>();
        public ProductController()
        {
            products = GetSampleProduct();
        }

        // the get all api operation
        public IEnumerable<ProductEntity1> get()
        {
            return products;
        }

        public ProductEntity1 get(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }


        private List<ProductEntity1> GetSampleProduct()
        {
            products.Add(new ProductEntity1() { ProductId = 1, Name = "Apple", Description = "fresh Golden fuji", Price = 12.1M});
            products.Add(new ProductEntity1() { ProductId = 2, Name = "Päron", Description = "Golden fuji", Price = 12.9M });
            products.Add(new ProductEntity1() { ProductId = 3, Name = "Banan", Description = "Golden fuji", Price = 13.1M });
            products.Add(new ProductEntity1() { ProductId = 4, Name = "Avocado", Description = "Golden fuji", Price = 14.1M });
            products.Add(new ProductEntity1() { ProductId = 5, Name = "Orange", Description = "Golden fuji", Price = 15.1M });
            return products;
        }


    }
}
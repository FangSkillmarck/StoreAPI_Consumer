using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreAPI.DTO
{
    public class ProductEntity1
    {
        // this is going to serve us as a message when 
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
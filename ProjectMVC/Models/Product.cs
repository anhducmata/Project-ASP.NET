using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string  ProductDescription { get; set; }

        public string ProductImage { get; set; }

        public int SupplierId { get; set; }

    }
}
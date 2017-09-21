using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Product
    {
        public Product()
        {
            
        }

        [Key]
        public int ProductId { get; set; }

        [MaxLength(50)]
        public string ProductName { get; set; }

        public string  ProductDescription { get; set; }

        public string ProductImage { get; set; }
        
        public int SuplierId { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("SuplierId")]
        public Suplier Suplier { get; set; }

    }
}
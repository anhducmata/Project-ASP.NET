using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Suplier
    {
        public Suplier() { }

        [Key]
        public int SuplierId { get; set; }

        [MaxLength(50)]
        public string SuplierName { get; set; }

        [MaxLength(200)]
        public string SuplierAddress { get; set; }
        
        public string SuplierDescription { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
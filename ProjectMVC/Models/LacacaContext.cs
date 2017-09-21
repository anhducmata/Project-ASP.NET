using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class LacacaContext : DbContext
    {
        public LacacaContext() : base("name=DB")
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(b => b.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            modelBuilder.Entity<Suplier>().Property(b => b.SuplierId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<ProjectMVC.Models.Suplier> Supliers { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using NLayerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayerRepository
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(
               
           new ProductFeature()
            {
                ID = 1,
                Color = "Mavi",
                Height = 200,
                Weight = 250,
                ProductId = 1,
            },
            new ProductFeature()
            {
                ID = 2,
                Color = "Sarı",
                Height = 100,
                Weight = 150,
                ProductId = 2,
            });
            //  modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}


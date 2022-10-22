using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
   public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {

            entityBuilder.HasIndex(X => X.ProductId);
            entityBuilder.Property(X => X.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(X => X.Description).IsRequired().HasMaxLength(500);

            //Product By default
            var products = new List<Product>();
            var random = new Random();

            for (var i = 1; i < 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000),


                });
            }

            entityBuilder.HasData(products);

        }
    }
}

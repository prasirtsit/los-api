using los_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Mocks
{
    public class ProductMock
    {
        public static void Create(IosDbContext context)
        {
            List<Product> products = new()
            {
                new Product
                {
                    Id = "b2d58cc5-8437-4b20-9004-45ff815f87a6",
                    Name = "Audi",
                    Price = 4999000
                },
                new Product
                {
                    Id = "d9f41bcc-db37-4262-bff5-b543fe54a62f",
                    Name = "BMW",
                    Price = 3999000
                },
                new Product
                {
                    Id = "d2f83744-9190-4be7-b98a-12921ad1a23a",
                    Name = "Mercedes Benz",
                    Price = 5999000
                },
                new Product
                {
                    Id = "bdec1435-3624-4b6c-a0e0-ff586262747a",
                    Name = "Volvo",
                    Price = 2999000
                }
            };

            context.AddRange(products);
            context.SaveChanges();
        }
    }
}

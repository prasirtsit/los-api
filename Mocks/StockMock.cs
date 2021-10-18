using los_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Mocks
{
    public class StockMock
    {
        public static void Create(IosDbContext context)
        {
            List<Stock> stocks = new()
            {
                new Stock
                {
                    Id = "f3215aec-d67c-4f93-8f56-eeb9bb127a52",
                    ProductId = "b2d58cc5-8437-4b20-9004-45ff815f87a6",
                    Amount = 8
                },
                new Stock
                {
                    Id = "bf56f75d-a8ee-42d2-825c-77beb7e3cb99",
                    ProductId = "d9f41bcc-db37-4262-bff5-b543fe54a62f",
                    Amount = 5
                },
                new Stock
                {
                    Id = "0d9d01b1-fe1c-4c32-80d5-7522d2bb3ed9",
                    ProductId = "d2f83744-9190-4be7-b98a-12921ad1a23a",
                    Amount = 2
                },
                new Stock
                {
                    Id = "90555728-fbcd-4ff7-8de8-eaff51f5ee36",
                    ProductId = "bdec1435-3624-4b6c-a0e0-ff586262747a",
                    Amount = 10
                }
            };

            context.AddRange(stocks);
            context.SaveChanges();
        }
    }
}

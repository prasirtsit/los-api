using los_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Services
{
    public class StockService
    {
        private readonly List<Product> product = new List<Product>()
        {
            new Product { id = "56fb0bee-bf63-4271-a06e-4fe61dbacb56", name = "Audi", imageUrl = null, price = 4999900},
            new Product { id = "c2c35bb6-c82f-4e30-9ac5-ed44327fadad", name = "BMW", imageUrl = null, price = 3999900},
            new Product { id = "083d9f34-01f6-4066-980a-36a56a6fdc13", name = "Mercedes Benz", imageUrl = null, price = 5999900},
            new Product { id = "8bc24064-3314-4041-983b-03a8652449c9", name = "Volvo", imageUrl = null, price = 2999900}
        };

        private readonly List<Stock> stock = new List<Stock>()
        {
            new Stock { id = "b4e6454c-9016-4cb7-b774-c6b53d30ba6e", productId = "56fb0bee-bf63-4271-a06e-4fe61dbacb56", amount = 10},
            new Stock { id = "a30fcdfa-3705-4a97-8fd4-d0f45f512636", productId = "c2c35bb6-c82f-4e30-9ac5-ed44327fadad", amount = 5},
            new Stock { id = "e406f312-9749-4633-aa98-b06c9c554161", productId = "083d9f34-01f6-4066-980a-36a56a6fdc13", amount = 2 },
            new Stock { id = "3dba6b56-cd97-4ba6-87bc-7d32ff8d8ccf", productId = "8bc24064-3314-4041-983b-03a8652449c9", amount = 8}
        };

        public Stock GetById(string productId)
        {
            return stock.Where(w => w.productId == productId).Select(s => new Stock
            {
                id = s.id,
                productId = s.productId,
                amount = s.amount,
                products = product.Where(w => w.id == productId).SingleOrDefault()
            }).SingleOrDefault();
        }
    }
}

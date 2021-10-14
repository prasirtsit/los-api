using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class Stock
    {
        public string id { get; set; }
        public string productId { get; set; }
        public int amount { get; set; }
        public Product products { get; set; }
    }
}

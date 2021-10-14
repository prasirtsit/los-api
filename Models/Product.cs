using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public byte[] imageUrl { get; set; }
        public float price { get; set; }
    }
}

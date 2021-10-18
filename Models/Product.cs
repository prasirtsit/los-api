using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public partial class Product
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }
        public virtual byte[] ImageUrl { get; set; }
        public virtual float Price { get; set; }
    }
}

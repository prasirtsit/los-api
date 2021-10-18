using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public partial class Stock
    {
        public virtual string Id { get; set; }
        public virtual string ProductId { get; set; }
        public virtual int Amount { get; set; }
    }
}

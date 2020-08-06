using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}

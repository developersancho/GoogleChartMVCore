using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleChartMVCore.Models
{
    public class ProductViewModel
    {
        public List<Product> findAll()
        {
            return new List<Product>()
            {
                new Product(){Id="1", Name="Name1", Price=1, Quantity = 4},
                new Product(){Id="2", Name="Name2", Price=2, Quantity = 13},
                new Product(){Id="3", Name="Name3", Price=3, Quantity = 23},
                new Product(){Id="4", Name="Name4", Price=4, Quantity = 12},
                new Product(){Id="5", Name="Name5", Price=5, Quantity = 43},
            };
        }
    }
}

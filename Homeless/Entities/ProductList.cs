using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeless.Entities
{
    public class ProductList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
    }
}

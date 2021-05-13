using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeless.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Weight { get; set; }
        //public string Material { get; set; }
        /*public string QuantityInStock { get; set; }*/ //количество на складе 
        //public string Color { get; set; }
        //public string Dimensions_LxWxH { get; set; }
        //public string Dimensions_LxDxH { get; set; }
    }
}

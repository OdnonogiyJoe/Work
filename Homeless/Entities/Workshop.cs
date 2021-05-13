using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeless.Entities
{
    public class Workshop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public List<Material> Materials { get; set; }
        public List<Product> Products { get; set; }
        public List<LostSoul> LostSouls { get; set; }
    }
}

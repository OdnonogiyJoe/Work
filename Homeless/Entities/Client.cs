﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeless.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
    }
}

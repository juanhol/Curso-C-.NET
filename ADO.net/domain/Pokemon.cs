﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace domain
{
    public class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Element Type { get; set; }

        public Element Weakness { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Brand
    {
        public int brandId { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return description;
        }
    }
}


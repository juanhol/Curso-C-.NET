using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int categoryId { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return description;
        }
    }

}

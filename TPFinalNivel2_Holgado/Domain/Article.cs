using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Domain
{
    public class Article
    {
        public int Id { get; set; }
        public string articleCode { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Brand  brand { get; set; }
        public Category category { get; set; }
        public string imgUrl { get; set; }
        public decimal price { get; set; }
    }
}

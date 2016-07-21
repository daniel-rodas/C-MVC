using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
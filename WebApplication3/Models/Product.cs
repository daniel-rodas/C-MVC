using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public decimal MSRP { get; set; }
        public decimal CurrentPrice { set; get; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
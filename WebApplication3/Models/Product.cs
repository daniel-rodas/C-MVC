using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public decimal MSRP { get; set; }
        public decimal CurrentPrice { set; get; }
        public string Url { get; set; }

        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
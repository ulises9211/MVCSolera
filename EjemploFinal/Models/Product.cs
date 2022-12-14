using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    public class Product
    {
        public Product()
        {
            productOrder = new HashSet<ProductOrder>();
        }
        [Key]
        public int id { get; set; }
        public string productName { get; set; }
        public virtual ICollection<ProductOrder> productOrder { get; set; }
    }
}
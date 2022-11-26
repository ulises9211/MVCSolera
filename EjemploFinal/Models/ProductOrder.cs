using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    public class ProductOrder
    {   
        public Order order { get; set; }
        public int orderId { get; set; }
        public Product product { get; set; }
        public int productId { get; set; }
    }
}
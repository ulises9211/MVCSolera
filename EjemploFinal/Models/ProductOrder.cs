using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    public class ProductOrder
    {
        [ForeignKey("orderId")]
        public Order order { get; set; }
        public int orderId { get; set; }
        [ForeignKey("productId")]
        public Product product { get; set; }
        public int productId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    public class Order
    {
        public Order()
        {
            productOrder = new HashSet<ProductOrder>();
        }
        [Key]
        public int id { get; set; }
        public DateTime? orderDate { get; set; }
        [ForeignKey("customerId")]
        public Customer customer { get; set; }
        public int customerId { get; set; }
        public virtual ICollection<ProductOrder> productOrder { get; set; }
    }   
}
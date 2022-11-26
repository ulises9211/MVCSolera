using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    public class Customer
    {
        public Customer()
        {
            order = new HashSet<Order>();
        }
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public virtual ICollection<Order> order { get; set; }
    }
}
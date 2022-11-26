using EjemploFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploFinal.ViewModel
{
    public class ProductOrderViewModel
    {
        public Product product { get; set; }
        public Order order { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjemploFinal.Models
{
    [Table("Client")]
    public class Customer
    {
        public Customer()
        {
            order = new HashSet<Order>();
        }
        [Key]
        public int id { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z ]{2,254}", ErrorMessage = "Solo acepta letras")]
        [StringLength(30)]
        [Column("FirstName")]
        [Display( Name = "Client Name")]
        public string name { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,5}", ErrorMessage = "No es un formato valido para email")]
        [StringLength(30)]
        public string email { get; set; }
        [Range(18,99)]
        public int age { get; set; }
        public virtual ICollection<Order> order { get; set; }
    }
}
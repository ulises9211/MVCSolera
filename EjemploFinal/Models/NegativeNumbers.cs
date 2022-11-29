using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EjemploFinal.Models
{
    public class NegativeNumbers : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.age <= 0)
            {
                return new ValidationResult("Solo puedes tener números positivos");
            }
            return ValidationResult.Success;

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.CustomValidations
{
    public class EmailCheck : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            string email = (string)value;
            if (email != null)
            {
                if (email.Contains("@@"))
                    return new ValidationResult("Geçersiz Mail Adresi girdiniz.");
                if (email.Contains(" "))
                    return new ValidationResult("Boşluk bırakmadan yazınız.");
            }

            return ValidationResult.Success;
        }
    }
}


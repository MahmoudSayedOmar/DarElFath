using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Validations
{
    class DataModelValidator
    {
        public static bool IsValid(Object obj)
        {
            return Validator.TryValidateObject(obj,
                new ValidationContext(obj),
                new Collection<ValidationResult>()
                );
        }
        public static void Validate(Object obj)
        {
             Validator.ValidateObject(obj,new ValidationContext(obj));
        }
    }
}

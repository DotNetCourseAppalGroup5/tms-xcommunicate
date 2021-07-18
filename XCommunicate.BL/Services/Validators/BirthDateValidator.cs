using System;
using System.ComponentModel.DataAnnotations;

namespace Services.Validators
{
    public class BirthDateValidator : ValidationAttribute
    {
        public BirthDateValidator() { }

        public override bool IsValid(object value)
        {
            string birthDate = (string)value;

            if (String.IsNullOrEmpty(birthDate))
            {
                return false;
            }

            DateTime date;

            if (DateTime.TryParse(birthDate, out date))
            {
                if (date.Year < 2011 && date.Year > 1950) return true;
            }

            return false;
        }
    }
}

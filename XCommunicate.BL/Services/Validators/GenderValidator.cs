using System.ComponentModel.DataAnnotations;

namespace Services.Validators
{
    public class GenderValidator : ValidationAttribute
    {
        public GenderValidator() { }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string gender = value.ToString().ToLower();

                if (gender.Equals("male") || gender.Equals("female")) return true;
            }

            return false;
        }
    }
}

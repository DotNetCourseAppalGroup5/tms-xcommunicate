using System.ComponentModel.DataAnnotations;

namespace Services.Validators
{
    public class ObsceneWordsValidator : ValidationAttribute
    {
        public ObsceneWordsValidator() { }

        private string[] ObsceneWordsArray = new string[] { "fuck", "shit", "nigger", "niger", "whore", "slut", "bitch", "gay", "asshole", "jerk", "stupid", "dick", "pussy" };

        public override bool IsValid(object value)
        {
            string login = (string)value;

            foreach (var word in ObsceneWordsArray)
            {
                if (login.Contains(word)) return false;
            }

            return true;
        }
    }
}

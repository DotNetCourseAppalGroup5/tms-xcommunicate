using Services.Validators;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        [ObsceneWordsValidator(ErrorMessage = "Login can't contain obscene words!")]
        public string Username { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class LoginCodeConfirmationViewModel
    {
        [Required]
        [Display(Name = "Confirmation code")]
        [MinLength(6, ErrorMessage = "Code length must be 6 symbols!")]
        [MaxLength(6, ErrorMessage = "Code length must be 6 symbols!")]
        public string Code { get; set; }
    }
}

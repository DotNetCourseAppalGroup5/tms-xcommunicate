using Services.Validators;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class UserProfileViewModel
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public string BirthDate { get; set; }

        [GenderValidator(ErrorMessage = "Please input male or female")]
        public string Gender { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        [MaxLength(30)]
        public string Town { get; set; }

        public string UserId { get; set; }
    }
}

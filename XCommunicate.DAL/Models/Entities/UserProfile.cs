using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public string Gender { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        [MaxLength(30)]
        public string Town { get; set; }

        public string Avatar { get; set; }

        public string AvatarFullSize { get; set; }

        public User User { get; set; }

        public UserProfile() { }
        public UserProfile(string firstName, string lastName, string birthDate, string gender, string country, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Country = country;
            Town = town;
        }
        public UserProfile(string id, string firstName, string lastName, string birthDate, string gender, string country, string town, User user)
        {
            UserId = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Country = country;
            Town = town;
            User = user;
        }
    }
}

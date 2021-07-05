using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }

        public User User { get; set; }
    }
}

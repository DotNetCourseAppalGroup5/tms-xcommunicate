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

        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        [MaxLength(1)]
        public char Gender { get; set; }
        
        [MaxLength(30)]
        public string Country { get; set; }
        
        [MaxLength(30)]
        public string Town { get; set; }

        public string Avatar { get; set; }

        public User User { get; set; }
    }
}

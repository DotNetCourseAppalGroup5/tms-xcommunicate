using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        public UserProfile Profile { get; set; }
        
        public virtual ICollection<Entity> Entities { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<Message> MessagesSent { get; set; }
        public virtual ICollection<UserStateHistory> UserStatesHistory { get; set; }

        public User()
        {
            Entities = new List<Entity>();
            GroupUsers = new List<GroupUser>();
            MessagesSent = new List<Message>();
            UserStatesHistory = new List<UserStateHistory>();
        }
    }
}

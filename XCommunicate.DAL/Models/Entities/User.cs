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

        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string EmailAddress { get; set; }

        public UserProfile Profile { get; set; }

        //public virtual ICollection<Entity> Entities { get; set; }
            //public virtual ICollection<GroupUser> GroupUsers { get; set; }
        //public virtual ICollection<Colleague> Colleagues { get; set; }
        //public virtual ICollection<Message> MessagesSent { get; set; }
        //public virtual ICollection<UserStateHistory> UserStatesHistory { get; set; }
        //public virtual ICollection<Like> Likes { get; set; }
        //public virtual ICollection<ConfirmationCode> ConfirmationCodes { get; set; }

        //public User()
        //{
        //    Entities = new List<Entity>();
        //    GroupUsers = new List<GroupUser>();
        //    Colleagues = new List<Colleague>();
        //    MessagesSent = new List<Message>();
        //    UserStatesHistory = new List<UserStateHistory>();
        //    Likes = new List<Like>();
        //    ConfirmationCodes = new List<ConfirmationCode>();
        //}
    }
}

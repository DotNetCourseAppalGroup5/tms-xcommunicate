using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }

        public UserProfile userProfile { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<Colleague> Colleagues { get; set; }
        public virtual ICollection<Message> MessagesSent { get; set; }
        public virtual ICollection<UserStateHistory> UserStatesHistory { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<ConfirmationCode> ConfirmationCodes { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }

        public User()
        {
            Entities = new List<Entity>();
            GroupUsers = new List<GroupUser>();
            Colleagues = new List<Colleague>();
            MessagesSent = new List<Message>();
            UserStatesHistory = new List<UserStateHistory>();
            Likes = new List<Like>();
            ConfirmationCodes = new List<ConfirmationCode>();
        }
    }
}

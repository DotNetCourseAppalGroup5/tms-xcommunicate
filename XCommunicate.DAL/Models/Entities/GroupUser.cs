using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class GroupUser
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        
        [Key, Column(Order = 1)]
        public int GroupId { get; set; }

        public int RoleId { get; set; }

        public virtual User User { get; set; }

        public virtual Group Group { get; set; }

        public virtual GroupRole Role { get; set; }
    }
}

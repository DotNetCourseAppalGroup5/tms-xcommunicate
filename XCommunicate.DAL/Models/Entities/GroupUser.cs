using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class GroupUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual List<Group> GroupsUser { get; set; }
        public int RoleId { get; set; }
        public virtual GroupRole Role { get; set; }
    }
}

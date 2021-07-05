using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class GroupRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<GroupUser> GroupUsers { get; set; }

        public GroupRole()
        {
            GroupUsers = new List<GroupUser>();
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class GroupRole
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<GroupUser> GroupUsers { get; set; }
    }
}

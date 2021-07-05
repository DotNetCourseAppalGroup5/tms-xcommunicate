using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string GroupDescription { get; set; }
        public bool IsPrivate { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }

        public Group()
        {
            Entities = new List<Entity>();
            GroupUsers = new List<GroupUser>();
        }
    }
}

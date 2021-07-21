using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "GroupDescription is required.")]
        public string GroupDescription { get; set; }
        [Required(ErrorMessage = "GroupAvatar is required.")]
        public string GroupAvatar { get; set; }
        public string GroupAvatarFullSize { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime CreateGroup { get; set; }
        public bool IsPrivate { get; set; }

        //public virtual ICollection<Entity> Entities { get; set; } ???????????

        public virtual List<GroupUser> GroupUsers { get; set; }
     public int Size { get; set; }

    }
}

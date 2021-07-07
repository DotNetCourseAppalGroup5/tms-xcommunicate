using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int EntityTypeId { get; set; }
        
        public DateTime UploadedAt { get; set; }
        
        public int UserId { get; set; }
        
        public virtual User User { get; set; }

        public string Content { get; set; }
        
        public string Image { get; set; }

        public int? EntityParentId { get; set; }

        public int? ParentGroupId { get; set; }
        

        public virtual EntityType EntityType { get; set; }

        public virtual Group ParentGroup { get; set; }
    }
}

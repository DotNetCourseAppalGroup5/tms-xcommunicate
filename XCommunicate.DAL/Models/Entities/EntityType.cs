using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class EntityType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
        public EntityType()
        {
            Entities = new List<Entity>();
        }
    }
}

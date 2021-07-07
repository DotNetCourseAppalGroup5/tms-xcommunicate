using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Like
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        
        [Key, Column(Order = 1)]
        public int EntityId { get; set; }
        
        public virtual User User { get; set; }

        public virtual Entity Entity { get; set; }
    }
}

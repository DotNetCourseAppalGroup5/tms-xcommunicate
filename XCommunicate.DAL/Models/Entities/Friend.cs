using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Friend
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key, Column(Order = 1)]
        public int FriendsId { get; set; }
        public virtual User Friends { get; set; }
    }
}

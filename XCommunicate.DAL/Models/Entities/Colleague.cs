using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Colleague
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key, Column(Order = 1)]
        public int ColleaguesId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class UserStateHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int UserStateId { get; set; }
        public virtual UserState UserState { get; set; }

        public DateTime StateUpdate { get; set; }
    }
}

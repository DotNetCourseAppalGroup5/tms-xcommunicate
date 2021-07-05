using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class ConfirmationCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreatedAt { get; set; }
        public string Code { get; set; }
        public bool IsConfirmed { get; set; }
    }
}

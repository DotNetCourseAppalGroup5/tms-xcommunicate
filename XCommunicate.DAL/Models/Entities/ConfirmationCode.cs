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

        public int? UserId { get; set; }
        
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        
        public string CreatedAt { get; set; }
        
        [MaxLength(6)]
        public string Code { get; set; }
        
        public bool IsConfirmed { get; set; }

        public virtual User User { get; set; }
    }
}

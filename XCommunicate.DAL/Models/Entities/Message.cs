using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? FromUserId { get; set; }
        
        public int? ToUserId { get; set; }
        
        public string Content { get; set; }
        
        public DateTime MessageDate { get; set; }

        public virtual User FromUser { get; set; }
    }
}

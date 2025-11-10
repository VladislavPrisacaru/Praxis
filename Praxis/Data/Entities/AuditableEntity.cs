using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Praxis.Data.Entities
{
    public abstract class AuditableEntity
    {
        [Required, StringLength(16)]
        public string CreatedBy { get; set; } = default!;
        public DateTime CreatedDate { get; set; }

        [StringLength(16)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        
    }
}

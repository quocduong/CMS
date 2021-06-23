using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}

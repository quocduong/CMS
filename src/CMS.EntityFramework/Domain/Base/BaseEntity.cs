using System;

namespace CMS.EntityFramework.Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

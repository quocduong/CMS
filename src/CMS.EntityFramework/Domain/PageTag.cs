using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class PageTag : BaseEntity
    {
        public Guid PageId { get; set; }

        [ForeignKey("PageId")]
        public virtual Page Page { get; set; }

        public Guid TagId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}

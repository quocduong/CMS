using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class NewsTag : BaseEntity
    {
        public Guid NewsId { get; set; }

        [ForeignKey("NewsId")]
        public virtual News News { get; set; }

        public Guid TagId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}

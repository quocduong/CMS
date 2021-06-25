using System;

namespace CMS.EntityFramework.Domain
{
    public class ProductTagMapping : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Tag Tag { get; set; }
    }
}

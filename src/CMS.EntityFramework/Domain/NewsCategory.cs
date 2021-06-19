using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class NewsCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Thumbnail { get; set; }
        public int Order { get; set; }
        public Guid ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual NewsCategory Parent { get; set; }
    }
}

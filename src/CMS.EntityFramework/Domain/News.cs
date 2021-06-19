using CMS.Shared.Enums.News;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public NewsEnums Status { get; set; }
        public int Order { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual NewsCategory Category { get; set; }
    }
}

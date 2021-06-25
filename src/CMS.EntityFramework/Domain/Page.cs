using CMS.EntityFramework.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class Page : SeoModel
    {
        [MaxLength(EntityLength.NameLength)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }
        public bool IsHomepage { get; set; }

        public bool ShowOnSitemap { get; set; }

        public DateTime? StartPublishingDate { get; set; }

        public DateTime? EndPublishingDate { get; set; }

        public int RecordOrder { get; set; }

        public bool IncludeInSiteNavigation { get; set; }
        public bool SlugEditable { get; set; } = true;
        public bool Deleteable { get; set; } = true;

        public Guid? ParentId { get; set; }

        public string Hierarchy { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        [ForeignKey("ParentId")]
        public virtual Page Parent { get; set; }

        public int Readers { get; set; }

        public virtual ICollection<Page> ChildrenPages { get; set; }

        public virtual ICollection<PageTag> PageTags { get; set; }

        public virtual ICollection<PageCategory> PageCategories { get; set; }
    }
}

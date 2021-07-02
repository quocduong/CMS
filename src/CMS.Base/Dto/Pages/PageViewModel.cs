using CMS.Base.Dto.PageCategories;
using CMS.Base.Dto.PageTag;
using System;
using System.Collections.Generic;

namespace CMS.Base.Dto.Pages
{
    public class PageViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }
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
        public string Language { get; set; }
        public int Readers { get; set; }
        public List<PageViewModel> ChildrenPages { get; set; }
        public List<PageTagViewModel> PageTags { get; set; }

        public virtual List<PageCategoryViewModel> PageCategories { get; set; }
    }
}

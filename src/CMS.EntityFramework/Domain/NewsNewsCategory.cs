using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class NewsNewsCategory
    {
        public NewsNewsCategory()
        {
            NewsCategories = new HashSet<NewsCategory>();
            News = new HashSet<News>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid NewsId { get; set; }
        public Guid NewsCategoryId { get; set; }

        public virtual ICollection<NewsCategory> NewsCategories { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}

using CMS.EntityFramework.Constants;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class SeoModel : BaseEntity
    {
        [MaxLength(EntityLength.DefaultLength)]
        public string MetaTitle { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string MetaDescription { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string OgTitle { get; set; }

        public string OgDescription { get; set; }
        public bool IsFollow { get; set; }
    }
}

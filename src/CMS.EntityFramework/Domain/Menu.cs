using CMS.EntityFramework.Constants;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class Menu : BaseEntity
    {
        [MaxLength(EntityLength.NormalLength)]
        public string DisplayName { get; set; }
        [MaxLength(EntityLength.NormalLength)]
        public string Url { get; set; }
        public int Order { get; set; }
        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Menu Parent { get; set; }
    }
}

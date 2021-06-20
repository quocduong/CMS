using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.EntityFramework.Domain
{
    public class ProductDetail : BaseEntity
    {
        public string  Name{ get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public int Quantity { get; set; }
        public Guid  ProductId{ get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }

    }
}

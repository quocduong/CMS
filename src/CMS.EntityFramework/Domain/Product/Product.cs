using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain.Product
{
    public class Product: BaseEntity
    {
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string Slug { get; set; }

        [MaxLength(20)]
        public string Code { get; set; }

        public double Price { get; set; }

        public int Status { get; set; }

        public int ProductCategoryId { get; set; }

        public int Quantity { get; set; }

    }
}

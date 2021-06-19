using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Base.Dto.Products
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public double Price { get; set; }

        public int Status { get; set; }

        public int ProductCategoryId { get; set; }

        public int Quantity { get; set; }
    }
}

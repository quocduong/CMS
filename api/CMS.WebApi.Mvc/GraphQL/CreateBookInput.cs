using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.WebApi.Mvc.GraphQL
{
    public class CreateBookInput
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
    }
}


using CMS.WebApi.Mvc.Context;
using CMS.WebApi.Mvc.Models;
using HotChocolate;
using System.Linq;

namespace CMS.WebApi.Mvc.GraphQL
{
    public class Query
    {
        private readonly DatabaseContext dbContext;

        public Query(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<Product> Product => dbContext.Products;

        public Product GetProduct([Service] DatabaseContext dbContext, int id) => dbContext.Products.FirstOrDefault(x => x.Id == id);
    }
}

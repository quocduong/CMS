using CMS.WebApi.Mvc.GraphQL;
using System.Linq;

namespace CMS.WebApi.Mvc.Core
{
    public interface IBookService
    {
        IQueryable<Book> GetAll();
        Book Create(CreateBookInput inputBook);

        Book Delete(DeleteBookInput inputBook);
    }
}

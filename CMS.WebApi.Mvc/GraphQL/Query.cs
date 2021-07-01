using CMS.WebApi.Mvc.Core;
using HotChocolate.Types;
using System.Linq;

namespace CMS.WebApi.Mvc.GraphQL
{
    public class Query
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public Query(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        [UsePaging(SchemaType = typeof(AuthorType))]
        [UseFiltering]
        public IQueryable<Author> Authors => _authorService.GetAll();

        [UsePaging(SchemaType = typeof(BookType))]
        [UseFiltering]
        public IQueryable<Book> Books => _bookService.GetAll();
    }
}

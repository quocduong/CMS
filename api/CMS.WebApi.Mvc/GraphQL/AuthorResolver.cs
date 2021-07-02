using CMS.WebApi.Mvc.Core;
using HotChocolate;
using HotChocolate.Resolvers;
using System.Linq;

namespace CMS.WebApi.Mvc.GraphQL
{
    public class AuthorResolver
    {
        private readonly IAuthorService _authorService;

        public AuthorResolver([Service] IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public Author GetAuthor(Book book, IResolverContext ctx)
        {
            return _authorService.GetAll().Where(a => a.Id == book.AuthorId).FirstOrDefault();
        }
    }
}

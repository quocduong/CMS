using CMS.WebApi.Mvc.Core.CustomException;
using HotChocolate;

namespace CMS.WebApi.Mvc.GraphQL.Filters
{
    public class BookNotFoundExceptionFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {
            if (error.Exception is BookNotFoundException ex)
                return error.WithMessage($"Book with id {ex.BookId} not found");

            return error;
        }
    }
}

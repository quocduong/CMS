using CMS.WebApi.Mvc.Core;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.WebApi.Mvc.GraphQL
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field(b => b.Id).Type<IdType>();
            descriptor.Field(b => b.Title).Type<StringType>();
            descriptor.Field(b => b.Price).Type<DecimalType>();
            descriptor.Field<AuthorResolver>(t => t.GetAuthor(default, default));
        }
    }
}

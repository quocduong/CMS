using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.WebApi.Mvc.Core.CustomException
{
    public class BookNotFoundException : Exception
    {
        public int BookId { get; internal set; }
    }
}

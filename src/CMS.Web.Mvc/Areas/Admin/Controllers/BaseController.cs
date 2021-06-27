using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Mvc.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILogger _logger;

        public BaseController(ILogger logger)
        {
            _logger = logger;
        }
    }
}

using CMS.Business.Interfaces.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Threading.Tasks;

namespace CMS.Web.Mvc.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PagesController : BaseController
    {
        private readonly IPageService _pageService;
        private readonly ILogger<PagesController> _logger;

        public PagesController(ILogger<PagesController> logger, IPageService pageService)
        {
            _pageService = pageService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        public ActionResult Index()
        {
            Log.Information("");
            _logger.LogInformation("");
            return View();
        }

        public async Task<IActionResult> GetPagesDataTable()
        {
            var pages = await _pageService.ReadAsync();

            return Json(pages);
        }
        
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

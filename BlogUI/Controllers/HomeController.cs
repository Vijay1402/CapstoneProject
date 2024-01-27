using BlogUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BlogLib;

namespace BlogUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        private readonly BlogRepository _blogRepository = new BlogRepository();

        public ActionResult Index()
        {
            var blogs = _blogRepository.GetAllBlogs();
            return View(blogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

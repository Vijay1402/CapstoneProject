using BlogLib;
using Microsoft.AspNetCore.Mvc;
using BlogLib;

namespace BlogUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string title, string subject, string blogUrl, string empEmailId)
        {
            
            var blog = new BlogInfo
            {
                Title = title,
                Subject = subject,
                DateOfCreation = DateTime.Now,
                BlogUrl = blogUrl,
                EmpEmailId = empEmailId
            };

            _blogRepository.SaveBlog(blog);

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

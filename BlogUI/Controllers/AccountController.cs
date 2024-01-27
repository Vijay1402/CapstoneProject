using Microsoft.AspNetCore.Mvc;
using BlogLib;

public class AccountController : Controller
{
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(string email, string password)
    {
        var isAdminValid = _employeeRepository.ValidateAdminLogin(email, password);
        if (isAdminValid)
        {
            RedirectToAction("Index", "Home");
        }
    }
}
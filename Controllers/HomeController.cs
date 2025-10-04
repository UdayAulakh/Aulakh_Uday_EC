using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // Home page
    public IActionResult Index()
    {
        return View(); // Loads Views/Home/Index.cshtml
    }

    // Resume page
    public IActionResult Resume()
    {
        return View(); // Loads Views/Home/Resume.cshtml
    }
}

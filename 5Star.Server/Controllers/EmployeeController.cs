using Microsoft.AspNetCore.Mvc;

namespace _5Star.Server.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

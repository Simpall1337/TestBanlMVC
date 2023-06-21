using Microsoft.AspNetCore.Mvc;

namespace TestBank.Controllers
{
    public class otherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

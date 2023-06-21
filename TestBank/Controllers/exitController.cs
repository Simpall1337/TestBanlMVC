using Microsoft.AspNetCore.Mvc;

namespace TestBank.Controllers
{
    public class exitController : Controller
    {
        public IActionResult Index()
        {
            Thread.Sleep(10000);
            return View();
        }
    }
}

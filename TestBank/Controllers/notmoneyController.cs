using Microsoft.AspNetCore.Mvc;

namespace TestBank.Controllers
{
    public class notmoneyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

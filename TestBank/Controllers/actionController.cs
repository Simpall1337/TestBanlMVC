using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;

namespace TestBank.Controllers
{
    public class actionController : Controller
    {
        public IActionResult Index(client cl)
        {

           return View();   

        }
    }
}

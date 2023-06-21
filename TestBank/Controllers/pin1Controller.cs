using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBank.Controllers
{
    public class pin1Controller : Controller
    {
        public IActionResult Index(client cl)
        {
           
                return View();
            
        }
    }
}

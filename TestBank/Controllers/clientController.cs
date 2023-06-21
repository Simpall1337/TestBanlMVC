using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestBank.DBConnect;
using TestBank.Models;

namespace TestBank.Controllers
{
    public class clientController : Controller
    {
        public static string name;
        public IActionResult Index(client cl)
        {
            using (OmegaDevelopmentContext db = new OmegaDevelopmentContext())
            {
                var users = db.Userdata.ToList();
                name = cl.Userlogin;

                foreach (var user in users)
                {
                    if (user.Userlogin == cl.Userlogin && user.Pin == cl.Pin)
                    {
                        var data = new { balance = user.Balance };
                        return Redirect("action");
                    }
                }

                return View();
            }

        }
    }
}
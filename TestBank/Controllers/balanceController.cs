using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBank.Controllers
{
    public class balanceController : Controller
    {
        public IActionResult Index(client cl)
        {
            using (OmegaDevelopmentContext db = new OmegaDevelopmentContext())
            {
                var users = db.Userdata.ToList();


                foreach (var user in users)
                {
                    if (user.Pin == cl.Pin && clientController.name == user.Userlogin)
                    {
                        var data = new { balance = user.Balance };
                        return View(data);
                    }
                   
                }

                return Redirect("pin1");
            }
        }
    }
}

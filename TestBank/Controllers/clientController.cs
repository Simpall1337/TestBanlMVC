using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestBank.DBConnect;
using TestBank.Models;

namespace TestBank.Controllers
{
    public class clientController : Controller
    {
        public static string name;

        private readonly OmegaDevelopmentContext _dbContext;

        public clientController(OmegaDevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(client cl)
        {
            
               // var users = db.Userdata.ToList();
                name = cl.Userlogin;
                var users = _dbContext.Userdata.ToList();
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
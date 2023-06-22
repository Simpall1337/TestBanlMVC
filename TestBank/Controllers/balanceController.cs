using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBank.Controllers
{
    public class balanceController : Controller
    {
        private readonly OmegaDevelopmentContext _dbContext;

        public balanceController(OmegaDevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(client cl)
        {
           
                
                var users = _dbContext.Userdata.ToList();

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

using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;

namespace TestBank.Controllers
{
    public class takemoneyController : Controller
    {
        private readonly OmegaDevelopmentContext _dbContext;

        public takemoneyController(OmegaDevelopmentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(FormModel formData)
        {
           
                var users = _dbContext.Userdata.ToList();

                foreach (var user in users) 
                {
                    if (user.Balance >  formData.FieldName && clientController.name == user.Userlogin)
                    {
                        return View();
                    }
                }

                
                return Redirect("NotMoney");
            
        }
    }
}

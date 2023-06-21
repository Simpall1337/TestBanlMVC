using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;

namespace TestBank.Controllers
{
    public class takemoneyController : Controller
    {
        public IActionResult Index(FormModel formData)
        {
            using (OmegaDevelopmentContext db = new OmegaDevelopmentContext())
            {
                var users = db.Userdata.ToList();


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
}

﻿using Microsoft.AspNetCore.Mvc;
using TestBank.DBConnect;
using TestBank.Models;
using TestBank.Controllers;

namespace TestBank.Controllers
{
    public class transactionController : Controller
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

                    return Redirect("pin2");
                }
            }
        
    }
}
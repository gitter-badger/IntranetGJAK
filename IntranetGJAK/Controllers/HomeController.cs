﻿using Microsoft.AspNet.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetGJAK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Log.ForContext("User", User.Identity.Name).Information("Requested Index");
            if (User.Identity.IsAuthenticated)
                return View();
            else
                return RedirectToAction("Login", "Account");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
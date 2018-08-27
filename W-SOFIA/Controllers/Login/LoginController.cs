using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Message"] = "Inicio de Session";
            return View();
        }
    }
}

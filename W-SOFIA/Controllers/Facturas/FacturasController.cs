using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers.Facturas
{
    public class FacturasController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Message"] = "Inicio de Session";
            return View();
        }

        public IActionResult Facturas()
        {
            ViewData["Title"] = "Facturacion";
            return View();
        }

    }
}
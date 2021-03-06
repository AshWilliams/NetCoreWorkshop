﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabMVC.Models;
using Microsoft.AspNetCore.Http;

namespace LabMVC.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Everyone")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("SessionTest", "Esta es una variable de sesión");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

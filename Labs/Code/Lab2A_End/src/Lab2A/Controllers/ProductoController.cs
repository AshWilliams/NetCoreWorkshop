using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2A.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab2A.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
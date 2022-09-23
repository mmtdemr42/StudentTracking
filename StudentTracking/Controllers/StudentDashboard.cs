using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTracking.PresentationLayer.Controllers
{
    public class StudentDashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

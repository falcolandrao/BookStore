using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithStateManagment.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult First()
    {
        TempData["UserId"] = 101;
        return View();
    }
    public IActionResult Second()
    {
        var userId = TempData["UserId"] ?? null;
        return View(userId);
    }
    public IActionResult Third()
    {
        var userId = TempData["UserId"] ?? null;
        return View(userId);
    }
    }
}

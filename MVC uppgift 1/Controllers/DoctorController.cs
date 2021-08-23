using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_uppgift_1.Models;

namespace MVC_uppgift_1.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult FeverCheck(string temp) {


            try
            {
                ViewBag.Msg = FeverHelper.Diagnose(temp);
                return View("Result");
            }
            catch
            {
                return View();
            }
        }
    }
}

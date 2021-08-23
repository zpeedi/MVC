using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_uppgift_1.Controllers
{
    public class GuessingGameController : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            Random rnd = new Random();
            HttpContext.Session.SetInt32("Number", rnd.Next(1, 101));
            HttpContext.Session.SetInt32("Guesses",0);
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            int guesses = (int)HttpContext.Session.GetInt32("Guesses");
            guesses++;
            HttpContext.Session.SetInt32("Guesses",guesses);
            ViewBag.Guesses = guesses;
            int number = (int) HttpContext.Session.GetInt32("Number");
            if (guess > number)
            {
                ViewBag.Msg = "Du gissade för högt!";
                return View();
            }
            else if(guess < number)
            {
                ViewBag.Msg = "Du gissade för lågt!";
                return View();
            }
            else
            {
                return View("Victory");
            }
        }
      
    }
}

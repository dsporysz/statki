using Ships2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ships2.Controllers
{
    public class HomeController : Controller
    {
        Game game;
        // GET: Home
        public ActionResult Index()
        {
            game = new Game();
            return View(game);
        }
        [HttpPost]
        public ActionResult Calculate(string txtX, string txtY)
        {
            string X = txtX.ToString();
            string Y = txtY.ToString();
            game.player1[5 * Convert.ToInt32(txtY) + Convert.ToInt32(txtX)] = field.Hit;
            return Content(X + ';' + Y);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Draw()
        {
            var model = new BoardModel
            {
                Points = new List<PointModel> 
                {
                    new PointModel {X = 10, Y = 20},
                    new PointModel {X = 30, Y = 23},
                    new PointModel {X = 22, Y = 40}
                }
            };
            return View(model);
        }
    }
}
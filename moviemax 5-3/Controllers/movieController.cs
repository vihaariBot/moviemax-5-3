using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace moviemax_5_3.Controllers
{
    public class movieController : Controller
    {
        // GET: movie
        public ActionResult filterby()
        {
            return View();
        }
    }
}
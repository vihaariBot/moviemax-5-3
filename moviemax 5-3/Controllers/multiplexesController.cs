using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviemax_5_3.Models;

namespace moviemax_5_3.Controllers
{
    public class multiplexesController : Controller
    {
        // GET: multiplexes
        public ActionResult showall()
        {
            database data = new database();
            var all = from i in data.multiplexs select i;
            List<multiplexmodel> muls = new List<multiplexmodel>();
            foreach(var i in all) {
                multiplexmodel m = new multiplexmodel();
                m.location = i.location;
                m.mulid = i.mulid;
                m.mulname = i.mulname;
                m.screens = i.screens;
                muls.Add(m);
            }

            return View(muls);
        }
        public ActionResult filterby(int mid)
        {
            database data = new database();
            
            //var all = from i in data.movies where i.multiplex.
            List<String> movies = new List<string>();
            var temp = data.multiplexs.Include("movie").Where(m => m.mulid == mid).Select(i=>i).FirstOrDefault();
           foreach(var mv in temp.movie) {
                movies.Add(mv.mname);
            }
            ViewBag.movies = movies;
                        
            return View();
        }
    }
}
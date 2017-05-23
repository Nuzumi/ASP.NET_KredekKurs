using MichalSewerniakZad5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichalSewerniakZad5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Nadawca> list;
            using (var ctx = new PostContext())
            {
                list = ctx.Nadawcy.Include(n => n.Adres).ToList();
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new PostContext())
            {
                var dbEntry = ctx.Nadawcy.SingleOrDefault(p => p.Id == id);
                var paczki = ctx.Przesylki.Where(p => p.Nadawca.Id == id).ToList();
                if (paczki.Count != 0)
                {
                    foreach(Przesylka przesylka in paczki)
                    {
                        ctx.Przesylki.Remove(przesylka);
                    }
                }
                ctx.Nadawcy.Remove(dbEntry);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View(new Nadawca());
        }

        [HttpPost]
        public ActionResult Add(Nadawca nadawca)
        {
            using(var ctx = new PostContext())
            {
                List<Nadawca> list = ctx.Nadawcy.Where(p => p.Nazwisko == nadawca.Nazwisko).ToList();
                if(list.Count == 0)
                {
                ctx.Nadawcy.Add(nadawca);
                ctx.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }

}
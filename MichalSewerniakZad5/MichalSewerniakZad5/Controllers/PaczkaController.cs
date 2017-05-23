using MichalSewerniakZad5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichalSewerniakZad5.Controllers
{
    public class PaczkaController : Controller
    {

        // GET: Paczka
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(int id)
        {
            return View(new Przesylka());
        }

        [HttpPost]
        public ActionResult Send(int id,Przesylka przesylka)
        {
            using(var ctx = new PostContext())
            {
                Nadawca nad;
                List<Nadawca> nadList = ctx.Nadawcy.Where(p => p.Nazwisko == przesylka.Nadawca.Nazwisko).ToList();
                if(nadList.Count == 0)
                {
                    nad = new Nadawca { Imie = przesylka.Nadawca.Imie, Nazwisko = przesylka.Nadawca.Nazwisko };
                }
                else
                {
                    nad = nadList[0];
                }
                przesylka.Nadawca = nad;
                Paczkomat pacz = ctx.Paczkomaty.First(p => p.Id == id);
                przesylka.Paczkomat = pacz;
                ctx.Przesylki.Add(przesylka);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
        
        public ActionResult ShowPrzesylki(int nadawcaId)
        {
            List<Przesylka> list;
            using(var ctx = new PostContext())
            {
                list = ctx.Przesylki.Include(p => p.Nadawca).Include(p => p.Odbiorca).Include(p => p.Paczkomat).Where(p => p.Nadawca.Id == nadawcaId).ToList();
            }

            return View(list);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new PostContext())
            {
                var dbEntry = ctx.Przesylki.SingleOrDefault(p => p.Id == id);
                ctx.Przesylki.Remove(dbEntry);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index","Home");
        }
    }
}
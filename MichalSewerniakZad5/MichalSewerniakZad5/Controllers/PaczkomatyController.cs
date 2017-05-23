using MichalSewerniakZad5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichalSewerniakZad5.Controllers
{
    public class PaczkomatyController : Controller
    {
        // GET: Paczkomaty
        public ActionResult Index()
        {
            List<Paczkomat> list;
            using(var ctx = new PostContext())
            {
                list = ctx.Paczkomaty.Include(p => p.Adres).ToList();
            }
            return View(list);
        }

        public ActionResult Add()
        {
            return View(new Paczkomat());
        }

        [HttpPost]
        public ActionResult Add(Paczkomat paczkomat)
        {
            using (var ctx = new PostContext())
            {
                ctx.Paczkomaty.Add(paczkomat);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
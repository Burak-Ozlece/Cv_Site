using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();
        public ActionResult Index()
        {
            var yetenek = repo.List();
            return View(yetenek);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var d = repo.Find(x=>x.Id == id);
            repo.Tdel(d);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDüzelt(int id)
        {
            var t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult YetenekDüzelt(TblYeteneklerim t)
        {
            TblYeteneklerim tblYeteneklerim = repo.Find(x=>x.Id == t.Id);
            tblYeteneklerim.Yetenek = t.Yetenek;
            tblYeteneklerim.Oran = t.Oran;
            repo.TUpdate(tblYeteneklerim);
            return RedirectToAction("Index");
        }
    }
}
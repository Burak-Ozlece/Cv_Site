using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            return View(repo.List());
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            var hobi = repo.Find(x=> x.Id == 1);
            hobi.Aciklama1 = p.Aciklama1;
            hobi.Aciklama2 = p.Aciklama2;
            repo.TUpdate(hobi);
            return RedirectToAction("Index");
        }
    }
}
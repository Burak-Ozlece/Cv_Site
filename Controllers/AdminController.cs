using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            return View(repo.List());
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(TblAdmin p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult AdminSil(int id)
        {
            TblAdmin t = repo.Find(x => x.Id == id);
            repo.Tdel(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminGetir(int Id)
        {
            TblAdmin t = repo.Find(x => x.Id == Id);
            return View(t);
        }
        [HttpPost]
        public ActionResult AdminGetir(TblAdmin p)
        {
            TblAdmin t = repo.Find(x => x.Id == p.Id);
            t.KullaniciAdi = p.KullaniciAdi;
            t.Parola = p.Parola ;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
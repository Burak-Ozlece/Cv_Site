using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TblHakkında> repo = new GenericRepository<TblHakkında>();
        public ActionResult Index()
        {
            return View(repo.List());
        }
        [HttpPost]
        public ActionResult Index(TblHakkında p)
        {
            var hakkimda = repo.Find(x => x.ID == 1);
            hakkimda.Ad = p.Ad;
            hakkimda.Soyad = p.Soyad;
            hakkimda.Adres = p.Adres;
            hakkimda.Acıklama = p.Acıklama;
            hakkimda.Eposta = p.Eposta;
            hakkimda.Telefon = p.Telefon;
            hakkimda.Resim = p.Resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}
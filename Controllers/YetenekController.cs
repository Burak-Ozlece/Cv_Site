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
    }
}
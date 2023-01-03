using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Tblİletisim> repo = new GenericRepository<Tblİletisim>();
        public ActionResult Index()
        {
            return View(repo.List());
        }
    }
}
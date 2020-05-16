using SinavOtomasyonMvc.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavOtomasyonMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var liste = OgrenciBL.OgrenciListele();
            return View(liste);
        }
    }
}
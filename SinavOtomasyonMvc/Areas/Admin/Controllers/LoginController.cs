using SinavOtomasyonMvc.BLL;
using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavOtomasyonMvc.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Manager m)
        {
            var sonuc = ManagerBL.ManagerKontrol(m);

            if (sonuc.ManagerId > 0)
                return Redirect("/Home/Index");

            return View();
        }
    }
}
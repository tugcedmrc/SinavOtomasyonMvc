﻿using SinavOtomasyonMvc.BLL;
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
            {
                Session["Admin"] = sonuc.KullaniciAd;
                return Redirect("/Home/Index");
            }
            return View();
        }

        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Manager m)
        {
            var sonuc = ManagerBL.Ekle(m);
            if (sonuc)
                return Redirect("Index");

            return View();
        }
    }
}
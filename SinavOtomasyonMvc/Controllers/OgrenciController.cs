using SinavOtomasyonMvc.BLL;
using SinavOtomasyonMvc.DAL;
using SinavOtomasyonMvc.Models;
using SinavOtomasyonMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavOtomasyonMvc.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            using (SinavContext ctx = new SinavContext())
            {
                OgrenciViewModel ovm = new OgrenciViewModel();
                ovm.Ogrencis = ctx.Ogrencis.ToList();
                return View(ovm);
            }
        }

        public ActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OgrenciEkle(FormCollection frm)
        {
            if (ModelState.IsValid)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = frm["txtAd"];
                ogr.Soyad = frm["txtSoyad"];
                ogr.KullaniciAdi = frm["txtKullaniciAd"];
                ogr.Sifre = frm["txtSifre"];
                var sonuc = OgrenciBL.OgrenciEkle(ogr);

                if (sonuc)
                    return Redirect("/Home/Index");

                return View();
            }

            return View();
        }

        public ActionResult OgrenciSil(int? Id)
        {
            OgrenciBL.OgrenciSil(Convert.ToInt32(Id));

            return Redirect("/Home/Index");
        }

        public ActionResult OgrenciGuncelle(int? id)
        {
            using (SinavContext ctx = new SinavContext())
            {
                var ogr = ctx.Ogrencis.Find(id);
                return View(ogr);
            }

        }

        [HttpPost]
        public ActionResult OgrenciGuncelle(Ogrenci ogr)
        {
            using (SinavContext ctx = new SinavContext())
            {
                ctx.Entry(ogr).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
                return View(ogr);
            }
            
        }
    }
}
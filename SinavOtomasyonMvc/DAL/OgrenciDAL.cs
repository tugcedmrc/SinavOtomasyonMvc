using SinavOtomasyonMvc.BLL;
using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.DAL
{
    public class OgrenciDAL
    {
        public static bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SinavContext ctx = new SinavContext();
                ctx.Ogrencis.Add(ogr);
                return ctx.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Ogrenci> OgrenciListele()
        {
            try
            {
                SinavContext ctx = new SinavContext();
                List<Ogrenci> lst = ctx.Ogrencis.ToList();
                if (lst != null)
                {
                    return lst;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool OgrenciSil(int Id)
        {
            try
            {
                SinavContext ctx = new SinavContext();
                var ogr = ctx.Ogrencis.Where(o => o.Id == Id).FirstOrDefault();
                if (ogr != null)
                {
                    ctx.Ogrencis.Remove(ogr);
                    return ctx.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Ogrenci OgrenciGetir(int Id)
        {
            SinavContext ctx = new SinavContext();
            var ogrenci = ctx.Ogrencis.Where(o => o.Id == Id).FirstOrDefault();
            if (ogrenci != null)
                return ogrenci;

            return null;
        }


    }
}
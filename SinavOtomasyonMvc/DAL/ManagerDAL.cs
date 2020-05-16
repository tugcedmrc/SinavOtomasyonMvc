using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.DAL
{
    public class ManagerDAL
    {
        public static Manager ManagerKontrol(Manager m)
        {
            try
            {
                SinavContext ctx = new SinavContext();
                Manager mng = (Manager)ctx.Managers.Where(o => o.KullaniciAd == m.KullaniciAd && o.Sifre == m.Sifre).FirstOrDefault();

                //Admin girişi sonrası session kontrolü için geriye giriş yapan kişiyi döndürüyoruz. Güncelleme silme ve ekleme işlemlerinde kullanacağız.
                return mng;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
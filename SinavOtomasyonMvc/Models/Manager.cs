using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını Yazınız")]
        public string KullaniciAd { get; set; }

        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

    }
}
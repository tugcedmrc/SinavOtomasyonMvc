using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }

        [Display(Name = "Öğrenci Adı")]
        [Required(ErrorMessage = "Adı Giriniz")]
        public string Ad { get; set; }

        [Display(Name = "Öğrenci Soyadı")]
        [Required(ErrorMessage = "Soyadı Giriniz")]
        public string Soyad { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string KullaniciAdi { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Sifre { get; set; }

    }
}
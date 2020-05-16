using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.Models.ViewModels
{
    public class OgrenciViewModel
    {
        public Ogrenci Ogrenci { get; set; }
        public IEnumerable<Ogrenci> Ogrencis { get; set; }

    }
}
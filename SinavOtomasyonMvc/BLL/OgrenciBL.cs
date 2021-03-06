﻿using SinavOtomasyonMvc.DAL;
using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.BLL
{
    public class OgrenciBL
    {
        public static bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                return OgrenciDAL.OgrenciEkle(ogr);
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
                return OgrenciDAL.OgrenciSil(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool OgrenciGuncelle(Ogrenci o)
        {
            try
            {
                return OgrenciDAL.OgrenciGuncelle(o);
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
                return OgrenciDAL.OgrenciListele();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Ogrenci OgrenciGetir(int Id)
        {
            try
            {
                return OgrenciDAL.OgrenciGetir(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
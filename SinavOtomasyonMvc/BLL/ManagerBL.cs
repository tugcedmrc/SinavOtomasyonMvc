using SinavOtomasyonMvc.DAL;
using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.BLL
{
    public class ManagerBL
    {
        public static Manager ManagerKontrol(Manager m)
        {
            try
            {
                return ManagerDAL.ManagerKontrol(m);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
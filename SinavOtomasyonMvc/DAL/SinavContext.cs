using SinavOtomasyonMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SinavOtomasyonMvc.DAL
{
    public class SinavContext : DbContext
    {
        public SinavContext() : base("cstr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(55).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.KullaniciAdi).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Sifre).HasColumnType("varchar").HasMaxLength(25).IsRequired();

            modelBuilder.Entity<Manager>().ToTable("tblManager");

            modelBuilder.Entity<Manager>().Property(m => m.KullaniciAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Manager>().Property(m => m.Sifre).HasColumnType("varchar").HasMaxLength(25).IsRequired();
        }

        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
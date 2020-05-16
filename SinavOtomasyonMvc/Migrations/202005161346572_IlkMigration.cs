namespace SinavOtomasyonMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IlkMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblManager",
                c => new
                    { 
                        ManagerId = c.Int(nullable: false, identity: true),
                        KullaniciAd = c.String(nullable: false, maxLength: 30, unicode: false),
                        Sifre = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.tblOgrenciler",
                c => new
                    {
                        OgrenciId = c.String(nullable: false, maxLength: 128),
                        Ad = c.String(nullable: false, maxLength: 50, unicode: false),
                        Soyad = c.String(nullable: false, maxLength: 55, unicode: false),
                        KullaniciAdi = c.String(nullable: false, maxLength: 30, unicode: false),
                        Sifre = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.OgrenciId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblOgrenciler");
            DropTable("dbo.tblManager");
        }
    }
}

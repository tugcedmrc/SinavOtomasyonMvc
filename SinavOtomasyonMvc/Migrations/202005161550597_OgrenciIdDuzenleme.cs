namespace SinavOtomasyonMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OgrenciIdDuzenleme : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tblOgrenciler");
            AddColumn("dbo.tblOgrenciler", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.tblOgrenciler", "Id");
            DropColumn("dbo.tblOgrenciler", "OgrenciId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblOgrenciler", "OgrenciId", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.tblOgrenciler");
            DropColumn("dbo.tblOgrenciler", "Id");
            AddPrimaryKey("dbo.tblOgrenciler", "OgrenciId");
        }
    }
}

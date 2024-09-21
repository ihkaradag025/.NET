namespace EntityCodeFirstOrnek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriTablosunuSilveKategorilerdeKategoriDeyaySil : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategoris", "KategoriDetay");
            DropTable("dbo.Musteris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                        MusteriSehir = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
        }
    }
}

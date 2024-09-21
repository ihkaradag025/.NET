namespace EntityCodeFirstOrnek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriisimToKategoriAdInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            Sql("Update Kategoris Set KategoriAd=Kategoriisim");
            DropColumn("dbo.Kategoris", "Kategoriisim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "Kategoriisim", c => c.String());
            Sql("Update Kategoris Set Kategoriisim=KategoriAd");
            DropColumn("dbo.Kategoris", "KategoriAd");
        }
    }
}

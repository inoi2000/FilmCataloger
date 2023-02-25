namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelatedFilms : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.FurtherInfoes", "Id", "dbo.Films");
            DropIndex("dbo.Films", new[] { "Films_Id" });
            AddColumn("dbo.Films", "FurtherInfo_Id", c => c.Int());
            AddColumn("dbo.Films", "FurtherInfo_FK_Id", c => c.Int());
            CreateIndex("dbo.Films", "FurtherInfo_Id");
            CreateIndex("dbo.Films", "FurtherInfo_FK_Id");
            AddForeignKey("dbo.Films", "FurtherInfo_Id", "dbo.FurtherInfoes", "Id");
            AddForeignKey("dbo.Films", "FurtherInfo_FK_Id", "dbo.FurtherInfoes", "Id");
            DropColumn("dbo.Films", "Films_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Films_Id", c => c.Int());
            DropForeignKey("dbo.Films", "FurtherInfo_FK_Id", "dbo.FurtherInfoes");
            DropForeignKey("dbo.Films", "FurtherInfo_Id", "dbo.FurtherInfoes");
            DropIndex("dbo.Films", new[] { "FurtherInfo_FK_Id" });
            DropIndex("dbo.Films", new[] { "FurtherInfo_Id" });
            DropColumn("dbo.Films", "FurtherInfo_FK_Id");
            DropColumn("dbo.Films", "FurtherInfo_Id");
            CreateIndex("dbo.Films", "Films_Id");
            AddForeignKey("dbo.FurtherInfoes", "Id", "dbo.Films", "Id");
            AddForeignKey("dbo.Films", "Films_Id", "dbo.Films", "Id");
        }
    }
}

namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "PictureRef", c => c.String());
            AddColumn("dbo.Categories", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Description");
            DropColumn("dbo.Categories", "PictureRef");
        }
    }
}

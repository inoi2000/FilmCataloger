namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addduration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Duration", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Duration");
        }
    }
}

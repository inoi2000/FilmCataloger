namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Gender");
        }
    }
}

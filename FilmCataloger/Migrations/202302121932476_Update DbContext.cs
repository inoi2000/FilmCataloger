namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDbContext : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CountriesFilms", newName: "FilmsCountries");
            DropPrimaryKey("dbo.FilmsCountries");
            AddPrimaryKey("dbo.FilmsCountries", new[] { "Films_Id", "Countries_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FilmsCountries");
            AddPrimaryKey("dbo.FilmsCountries", new[] { "Countries_Id", "Films_Id" });
            RenameTable(name: "dbo.FilmsCountries", newName: "CountriesFilms");
        }
    }
}

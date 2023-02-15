namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcategories : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FilmsCountries", newName: "CountriesFilms");
            DropPrimaryKey("dbo.CountriesFilms");
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FilmsCategories",
                c => new
                    {
                        Films_Id = c.Int(nullable: false),
                        Categories_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Films_Id, t.Categories_Id })
                .ForeignKey("dbo.Films", t => t.Films_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Categories_Id, cascadeDelete: true)
                .Index(t => t.Films_Id)
                .Index(t => t.Categories_Id);
            
            CreateTable(
                "dbo.PersonsCategories",
                c => new
                    {
                        Persons_Id = c.Int(nullable: false),
                        Categories_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Persons_Id, t.Categories_Id })
                .ForeignKey("dbo.Persons", t => t.Persons_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Categories_Id, cascadeDelete: true)
                .Index(t => t.Persons_Id)
                .Index(t => t.Categories_Id);
            
            AddColumn("dbo.Persons", "Сountry_Id", c => c.Int());
            AddPrimaryKey("dbo.CountriesFilms", new[] { "Countries_Id", "Films_Id" });
            CreateIndex("dbo.Persons", "Сountry_Id");
            AddForeignKey("dbo.Persons", "Сountry_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persons", "Сountry_Id", "dbo.Countries");
            DropForeignKey("dbo.PersonsCategories", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.PersonsCategories", "Persons_Id", "dbo.Persons");
            DropForeignKey("dbo.FilmsCategories", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.FilmsCategories", "Films_Id", "dbo.Films");
            DropIndex("dbo.PersonsCategories", new[] { "Categories_Id" });
            DropIndex("dbo.PersonsCategories", new[] { "Persons_Id" });
            DropIndex("dbo.FilmsCategories", new[] { "Categories_Id" });
            DropIndex("dbo.FilmsCategories", new[] { "Films_Id" });
            DropIndex("dbo.Persons", new[] { "Сountry_Id" });
            DropPrimaryKey("dbo.CountriesFilms");
            DropColumn("dbo.Persons", "Сountry_Id");
            DropTable("dbo.PersonsCategories");
            DropTable("dbo.FilmsCategories");
            DropTable("dbo.Categories");
            AddPrimaryKey("dbo.CountriesFilms", new[] { "Films_Id", "Countries_Id" });
            RenameTable(name: "dbo.CountriesFilms", newName: "FilmsCountries");
        }
    }
}

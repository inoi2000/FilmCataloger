namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Production = c.DateTime(nullable: false),
                        IMDb = c.Single(nullable: false),
                        PictureRef = c.String(),
                        Films_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Films_Id)
                .Index(t => t.Films_Id);
            
            CreateTable(
                "dbo.FurtherInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(),
                        AgrLimit = c.Int(nullable: false),
                        Fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PictureRef = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GenresFilms",
                c => new
                    {
                        Genres_Id = c.Int(nullable: false),
                        Films_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genres_Id, t.Films_Id })
                .ForeignKey("dbo.Genres", t => t.Genres_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Films_Id, cascadeDelete: true)
                .Index(t => t.Genres_Id)
                .Index(t => t.Films_Id);
            
            CreateTable(
                "dbo.PersonsFilms",
                c => new
                    {
                        Persons_Id = c.Int(nullable: false),
                        Films_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Persons_Id, t.Films_Id })
                .ForeignKey("dbo.Persons", t => t.Persons_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Films_Id, cascadeDelete: true)
                .Index(t => t.Persons_Id)
                .Index(t => t.Films_Id);
            
            CreateTable(
                "dbo.ProfessionPersons",
                c => new
                    {
                        Profession_Id = c.Int(nullable: false),
                        Persons_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Profession_Id, t.Persons_Id })
                .ForeignKey("dbo.Professions", t => t.Profession_Id, cascadeDelete: true)
                .ForeignKey("dbo.Persons", t => t.Persons_Id, cascadeDelete: true)
                .Index(t => t.Profession_Id)
                .Index(t => t.Persons_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.ProfessionPersons", "Persons_Id", "dbo.Persons");
            DropForeignKey("dbo.ProfessionPersons", "Profession_Id", "dbo.Professions");
            DropForeignKey("dbo.PersonsFilms", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.PersonsFilms", "Persons_Id", "dbo.Persons");
            DropForeignKey("dbo.GenresFilms", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.GenresFilms", "Genres_Id", "dbo.Genres");
            DropForeignKey("dbo.FurtherInfoes", "Id", "dbo.Films");
            DropIndex("dbo.ProfessionPersons", new[] { "Persons_Id" });
            DropIndex("dbo.ProfessionPersons", new[] { "Profession_Id" });
            DropIndex("dbo.PersonsFilms", new[] { "Films_Id" });
            DropIndex("dbo.PersonsFilms", new[] { "Persons_Id" });
            DropIndex("dbo.GenresFilms", new[] { "Films_Id" });
            DropIndex("dbo.GenresFilms", new[] { "Genres_Id" });
            DropIndex("dbo.FurtherInfoes", new[] { "Id" });
            DropIndex("dbo.Films", new[] { "Films_Id" });
            DropTable("dbo.ProfessionPersons");
            DropTable("dbo.PersonsFilms");
            DropTable("dbo.GenresFilms");
            DropTable("dbo.Professions");
            DropTable("dbo.Persons");
            DropTable("dbo.Genres");
            DropTable("dbo.FurtherInfoes");
            DropTable("dbo.Films");
        }
    }
}

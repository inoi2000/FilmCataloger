namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class udtCategories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.Persons", "Categories_Id", "dbo.Categories");
            DropIndex("dbo.Films", new[] { "Categories_Id" });
            DropIndex("dbo.Persons", new[] { "Categories_Id" });
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
            
            DropColumn("dbo.Films", "Categories_Id");
            DropColumn("dbo.Persons", "Categories_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "Categories_Id", c => c.Int());
            AddColumn("dbo.Films", "Categories_Id", c => c.Int());
            DropForeignKey("dbo.PersonsCategories", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.PersonsCategories", "Persons_Id", "dbo.Persons");
            DropForeignKey("dbo.FilmsCategories", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.FilmsCategories", "Films_Id", "dbo.Films");
            DropIndex("dbo.PersonsCategories", new[] { "Categories_Id" });
            DropIndex("dbo.PersonsCategories", new[] { "Persons_Id" });
            DropIndex("dbo.FilmsCategories", new[] { "Categories_Id" });
            DropIndex("dbo.FilmsCategories", new[] { "Films_Id" });
            DropTable("dbo.PersonsCategories");
            DropTable("dbo.FilmsCategories");
            CreateIndex("dbo.Persons", "Categories_Id");
            CreateIndex("dbo.Films", "Categories_Id");
            AddForeignKey("dbo.Persons", "Categories_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Films", "Categories_Id", "dbo.Categories", "Id");
        }
    }
}

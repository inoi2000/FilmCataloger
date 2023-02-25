namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCategories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmsCategories", "Films_Id", "dbo.Films");
            DropForeignKey("dbo.FilmsCategories", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.PersonsCategories", "Persons_Id", "dbo.Persons");
            DropForeignKey("dbo.PersonsCategories", "Categories_Id", "dbo.Categories");
            DropIndex("dbo.FilmsCategories", new[] { "Films_Id" });
            DropIndex("dbo.FilmsCategories", new[] { "Categories_Id" });
            DropIndex("dbo.PersonsCategories", new[] { "Persons_Id" });
            DropIndex("dbo.PersonsCategories", new[] { "Categories_Id" });
            AddColumn("dbo.Films", "Categories_Id", c => c.Int());
            AddColumn("dbo.Persons", "Categories_Id", c => c.Int());
            CreateIndex("dbo.Films", "Categories_Id");
            CreateIndex("dbo.Persons", "Categories_Id");
            AddForeignKey("dbo.Films", "Categories_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Persons", "Categories_Id", "dbo.Categories", "Id");
            DropTable("dbo.FilmsCategories");
            DropTable("dbo.PersonsCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PersonsCategories",
                c => new
                    {
                        Persons_Id = c.Int(nullable: false),
                        Categories_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Persons_Id, t.Categories_Id });
            
            CreateTable(
                "dbo.FilmsCategories",
                c => new
                    {
                        Films_Id = c.Int(nullable: false),
                        Categories_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Films_Id, t.Categories_Id });
            
            DropForeignKey("dbo.Persons", "Categories_Id", "dbo.Categories");
            DropForeignKey("dbo.Films", "Categories_Id", "dbo.Categories");
            DropIndex("dbo.Persons", new[] { "Categories_Id" });
            DropIndex("dbo.Films", new[] { "Categories_Id" });
            DropColumn("dbo.Persons", "Categories_Id");
            DropColumn("dbo.Films", "Categories_Id");
            CreateIndex("dbo.PersonsCategories", "Categories_Id");
            CreateIndex("dbo.PersonsCategories", "Persons_Id");
            CreateIndex("dbo.FilmsCategories", "Categories_Id");
            CreateIndex("dbo.FilmsCategories", "Films_Id");
            AddForeignKey("dbo.PersonsCategories", "Categories_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PersonsCategories", "Persons_Id", "dbo.Persons", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FilmsCategories", "Categories_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FilmsCategories", "Films_Id", "dbo.Films", "Id", cascadeDelete: true);
        }
    }
}

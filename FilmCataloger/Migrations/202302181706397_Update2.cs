﻿namespace FilmCataloger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FurtherInfoes", "AgeLimit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FurtherInfoes", "AgeLimit", c => c.Int(nullable: false));
        }
    }
}

namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingmodelclass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieId", c => c.Int(nullable: false));
        }
    }
}

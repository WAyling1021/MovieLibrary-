namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        Title = c.String(),
                        Genre = c.String(),
                        DirectorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}

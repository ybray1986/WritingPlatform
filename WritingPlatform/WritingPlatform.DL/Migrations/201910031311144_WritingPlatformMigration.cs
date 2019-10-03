namespace WritingPlatform.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WritingPlatformMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublishedDate = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Messages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.Int(nullable: false),
                    CompositionId = c.Int(nullable: false),
                    PublishedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .ForeignKey("dbo.Compositions", t => t.Id);


            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compositions", "GenreId", "dbo.Genres");
            DropIndex("dbo.Compositions", new[] { "Genre_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
            DropTable("dbo.Genres");
            DropTable("dbo.Compositions");
        }
    }
}

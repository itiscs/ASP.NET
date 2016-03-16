namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Blog_BlogID = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogID)
                .Index(t => t.Blog_BlogID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Blog_BlogID", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Blog_BlogID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}

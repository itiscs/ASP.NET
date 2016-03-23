namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttrRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Blogs", "Name", c => c.String());
        }
    }
}

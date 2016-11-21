namespace WebAppSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_student_newproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "NewProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "NewProperty");
        }
    }
}

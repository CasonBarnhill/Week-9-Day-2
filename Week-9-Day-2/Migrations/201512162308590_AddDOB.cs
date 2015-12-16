namespace Week_9_Day_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DOB", c => c.String());
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "DriversLicense", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DriversLicense", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}

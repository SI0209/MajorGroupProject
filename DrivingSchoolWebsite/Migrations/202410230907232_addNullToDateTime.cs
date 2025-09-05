namespace DrivingSchoolWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNullToDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "LearnerLicenseIssueDate", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "LearnerLicenseExpiryDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LearnerLicenseExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "LearnerLicenseIssueDate", c => c.DateTime(nullable: false));
        }
    }
}

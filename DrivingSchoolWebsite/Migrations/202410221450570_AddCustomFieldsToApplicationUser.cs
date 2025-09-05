namespace DrivingSchoolWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomFieldsToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IDNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "StreetAddress", c => c.String());
            AddColumn("dbo.AspNetUsers", "Suburb", c => c.String());
            AddColumn("dbo.AspNetUsers", "Race", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LessonCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "LearnerLicenseIssueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LearnerLicenseExpiryDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LearnerLicenseExpiryDate");
            DropColumn("dbo.AspNetUsers", "LearnerLicenseIssueDate");
            DropColumn("dbo.AspNetUsers", "LessonCode");
            DropColumn("dbo.AspNetUsers", "Age");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Race");
            DropColumn("dbo.AspNetUsers", "Suburb");
            DropColumn("dbo.AspNetUsers", "StreetAddress");
            DropColumn("dbo.AspNetUsers", "IDNumber");
        }
    }
}

namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCreatedByColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "CreatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CreatedBy", c => c.Int(nullable: false));
        }
    }
}

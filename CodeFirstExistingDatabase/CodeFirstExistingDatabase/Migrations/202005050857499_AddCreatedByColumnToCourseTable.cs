namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedByColumnToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CreatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CreatedBy");
        }
    }
}

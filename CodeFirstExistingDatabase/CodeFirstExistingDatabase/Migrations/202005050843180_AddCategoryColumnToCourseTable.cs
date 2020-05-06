namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Categories_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Categories_Id");
            AddForeignKey("dbo.Courses", "Categories_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Categories_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Categories_Id" });
            DropColumn("dbo.Courses", "Categories_Id");
        }
    }
}

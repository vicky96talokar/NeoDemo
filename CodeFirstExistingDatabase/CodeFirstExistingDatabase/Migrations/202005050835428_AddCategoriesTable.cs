namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories VALUES(1,'ASP.NET')");
            Sql("INSERT INTO Categories VALUES(2,'WEBAPI')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}

namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryTable : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories(CategoryName) SELECT CategoryName FROM _Categories");
            DropTable("dbo.Categories");
        }
    }
}

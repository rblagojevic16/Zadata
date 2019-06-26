namespace Zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "CategoryId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "CategoryId");
            AddForeignKey("dbo.Customers", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Customers", new[] { "CategoryId" });
            DropColumn("dbo.Customers", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}

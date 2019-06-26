namespace Zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Cars", "GenreId");
            AddForeignKey("dbo.Cars", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "GenreId", "dbo.Genres");
            DropIndex("dbo.Cars", new[] { "GenreId" });
            AlterColumn("dbo.Cars", "Name", c => c.String());
            DropColumn("dbo.Cars", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}

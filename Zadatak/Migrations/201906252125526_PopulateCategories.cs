namespace Zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id) VALUES(1)");
            Sql("INSERT INTO Categories (Id) VALUES(2)");
            Sql("INSERT INTO Categories (Id) VALUES(3)");
            Sql("INSERT INTO Categories (Id) VALUES(4)");
        }
        
        public override void Down()
        {
        }
    }
}

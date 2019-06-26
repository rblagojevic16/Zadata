namespace Zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String(nullable: false));

            Sql("UPDATE Categories SET Name='B' WHERE Id=1");
            Sql("UPDATE Categories SET Name='C' WHERE Id=2");
            Sql("UPDATE Categories SET Name='B,C' WHERE Id=3");
            Sql("UPDATE Categories SET Name='B' WHERE Id=4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Name");
        }
    }
}

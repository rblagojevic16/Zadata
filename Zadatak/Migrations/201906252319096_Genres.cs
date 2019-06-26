namespace Zadatak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Id, Name) VALUES (17, 'Moped')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (18, 'Automobil')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (19, 'Kamion')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (20, 'Autobus')");
        }
        
        public override void Down()
        {
        }
    }
}

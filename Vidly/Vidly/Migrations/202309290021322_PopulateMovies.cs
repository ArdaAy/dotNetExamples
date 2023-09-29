namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Pirates','2021-12-01 14:30:15','2022-12-01 14:30:15',10,1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Cengiz Land','2020-12-01 14:30:15','2021-12-01 14:30:15',15,2)");
        }
        
        public override void Down()
        {
        }
    }
}

namespace fix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulationMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Movies ( Name, Genre, ReleaseDate, DateAdded, stock) Values('Predator', 'Action', 1,2,5) ");

        }

        public override void Down()
        {
        }
    }
}

namespace NewVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.MovieGenres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO dbo.MovieGenres (Name) VALUES ('Action')");
            Sql("INSERT INTO dbo.MovieGenres (Name) VALUES ('Family')");
            Sql("INSERT INTO dbo.MovieGenres (Name) VALUES ('Romance')");
            Sql("INSERT INTO dbo.MovieGenres (Name) VALUES ('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}

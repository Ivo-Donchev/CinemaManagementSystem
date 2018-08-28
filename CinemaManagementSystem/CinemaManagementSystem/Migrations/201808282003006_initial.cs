namespace CinemaManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                        DistrictForeignKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictForeignKey, cascadeDelete: true)
                .Index(t => t.DistrictForeignKey);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                        CityForeignKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityForeignKey, cascadeDelete: true)
                .Index(t => t.CityForeignKey);
            
            CreateTable(
                "dbo.FilmScreenings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentForeignKey = c.Int(nullable: false),
                        MovieForeignKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentForeignKey, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieForeignKey, cascadeDelete: true)
                .Index(t => t.DepartmentForeignKey)
                .Index(t => t.MovieForeignKey);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FilmScreeningForeignKey = c.Int(nullable: false),
                        UserForeignKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FilmScreenings", t => t.FilmScreeningForeignKey, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserForeignKey, cascadeDelete: true)
                .Index(t => t.FilmScreeningForeignKey)
                .Index(t => t.UserForeignKey);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 32),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "UserForeignKey", "dbo.Users");
            DropForeignKey("dbo.Tickets", "FilmScreeningForeignKey", "dbo.FilmScreenings");
            DropForeignKey("dbo.FilmScreenings", "MovieForeignKey", "dbo.Movies");
            DropForeignKey("dbo.FilmScreenings", "DepartmentForeignKey", "dbo.Departments");
            DropForeignKey("dbo.Departments", "CityForeignKey", "dbo.Cities");
            DropForeignKey("dbo.Cities", "DistrictForeignKey", "dbo.Districts");
            DropIndex("dbo.Tickets", new[] { "UserForeignKey" });
            DropIndex("dbo.Tickets", new[] { "FilmScreeningForeignKey" });
            DropIndex("dbo.FilmScreenings", new[] { "MovieForeignKey" });
            DropIndex("dbo.FilmScreenings", new[] { "DepartmentForeignKey" });
            DropIndex("dbo.Departments", new[] { "CityForeignKey" });
            DropIndex("dbo.Cities", new[] { "DistrictForeignKey" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Movies");
            DropTable("dbo.FilmScreenings");
            DropTable("dbo.Departments");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
        }
    }
}

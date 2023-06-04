namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(),
                        EVUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.EVUser_Id)
                .Index(t => t.EVUser_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        ChargedTimes = c.Int(),
                        Paid = c.Int(),
                        RegDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Plan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plans", t => t.Plan_Id)
                .Index(t => t.Plan_Id);
            
            CreateTable(
                "dbo.ChargingStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StationID = c.String(),
                        State = c.String(),
                        StationAddress = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ChargingPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChName = c.String(),
                        Amount = c.Int(nullable: false),
                        ChargingStation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChargingStations", t => t.ChargingStation_Id)
                .Index(t => t.ChargingStation_Id);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                        PurchasedDate = c.DateTime(),
                        ServiceProvider_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceProviders", t => t.ServiceProvider_Id)
                .Index(t => t.ServiceProvider_Id);
            
            CreateTable(
                "dbo.ServiceProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        EstablishDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        EVUsers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.EVUsers_Id)
                .Index(t => t.EVUsers_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "EVUsers_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Plan_Id", "dbo.Plans");
            DropForeignKey("dbo.ServiceProviders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Plans", "ServiceProvider_Id", "dbo.ServiceProviders");
            DropForeignKey("dbo.Banks", "EVUser_Id", "dbo.Users");
            DropForeignKey("dbo.ChargingStations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ChargingPoints", "ChargingStation_Id", "dbo.ChargingStations");
            DropIndex("dbo.Vehicles", new[] { "EVUsers_Id" });
            DropIndex("dbo.ServiceProviders", new[] { "User_Id" });
            DropIndex("dbo.Plans", new[] { "ServiceProvider_Id" });
            DropIndex("dbo.ChargingPoints", new[] { "ChargingStation_Id" });
            DropIndex("dbo.ChargingStations", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Plan_Id" });
            DropIndex("dbo.Banks", new[] { "EVUser_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.ServiceProviders");
            DropTable("dbo.Plans");
            DropTable("dbo.ChargingPoints");
            DropTable("dbo.ChargingStations");
            DropTable("dbo.Users");
            DropTable("dbo.Banks");
        }
    }
}

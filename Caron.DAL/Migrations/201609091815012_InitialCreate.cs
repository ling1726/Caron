namespace Caron.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Message = c.String(maxLength: 500),
                        Email = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.DescriptionSections",
                c => new
                    {
                        DescriptionId = c.Int(nullable: false, identity: true),
                        DescriptionBody = c.String(maxLength: 800),
                        DescriptionTitle = c.String(maxLength: 70),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DescriptionId);
            
            CreateTable(
                "dbo.GalleryImages",
                c => new
                    {
                        GalleryImageId = c.Int(nullable: false, identity: true),
                        GalleryImagePath = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.GalleryImageId);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        RateId = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NightlyRate = c.Int(nullable: false),
                        Description = c.String(maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RateId);
            
            CreateTable(
                "dbo.ReservationPeriods",
                c => new
                    {
                        ReservationPeriodId = c.Int(nullable: false, identity: true),
                        RateId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationPeriodId)
                .ForeignKey("dbo.Rates", t => t.RateId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.RateId)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReserationId = c.Int(nullable: false, identity: true),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        NumberOfPeople = c.Byte(nullable: false),
                        Comments = c.String(maxLength: 500),
                        CreatedById = c.Int(nullable: false),
                        HasPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReserationId)
                .ForeignKey("dbo.Users", t => t.CreatedById, cascadeDelete: true)
                .Index(t => t.CreatedById);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 70),
                        Firstname = c.String(maxLength: 70),
                        Lastname = c.String(maxLength: 70),
                        Country = c.String(maxLength: 70),
                        City = c.String(maxLength: 70),
                        Address = c.String(maxLength: 150),
                        Postcode = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        ReviewComment = c.String(maxLength: 500),
                        ReviewerName = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.ReviewId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationPeriods", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "CreatedById", "dbo.Users");
            DropForeignKey("dbo.ReservationPeriods", "RateId", "dbo.Rates");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Reservations", new[] { "CreatedById" });
            DropIndex("dbo.ReservationPeriods", new[] { "ReservationId" });
            DropIndex("dbo.ReservationPeriods", new[] { "RateId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.ReservationPeriods");
            DropTable("dbo.Rates");
            DropTable("dbo.GalleryImages");
            DropTable("dbo.DescriptionSections");
            DropTable("dbo.Contacts");
        }
    }
}

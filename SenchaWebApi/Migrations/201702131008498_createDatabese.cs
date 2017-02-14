namespace SenchaWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDatabese : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeReservation = c.String(nullable: false, maxLength: 10),
                        CreationDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CheckInDate = c.DateTime(),
                        ChcekOutDate = c.DateTime(),
                        Commission = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 30),
                        ReservationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId)
                .Index(t => t.ReservationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitors", "ReservationId", "dbo.Reservations");
            DropIndex("dbo.Visitors", new[] { "ReservationId" });
            DropTable("dbo.Visitors");
            DropTable("dbo.Reservations");
        }
    }
}

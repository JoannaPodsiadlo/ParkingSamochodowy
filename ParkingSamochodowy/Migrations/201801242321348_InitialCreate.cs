namespace ParkingSamochodowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uzytkownik",
                c => new
                    {
                        UzytkownikId = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Haslo = c.String(),
                        NrRejestracyjnyPojazdu = c.String(),
                        IDUzytkownika = c.String(),
                    })
                .PrimaryKey(t => t.UzytkownikId);
            
            CreateTable(
                "dbo.Rezerwacjas",
                c => new
                    {
                        RezerwacjaId = c.Int(nullable: false, identity: true),
                        DataOd = c.DateTime(nullable: false),
                        DataDo = c.DateTime(nullable: false),
                        WybraneMiejsce = c.String(),
                        UzytkownikId = c.Int(nullable: false),
                        P_ParkingId = c.Int(),
                    })
                .PrimaryKey(t => t.RezerwacjaId)
                .ForeignKey("dbo.Parkings", t => t.P_ParkingId)
                .ForeignKey("dbo.Uzytkownik", t => t.UzytkownikId, cascadeDelete: true)
                .Index(t => t.UzytkownikId)
                .Index(t => t.P_ParkingId);
            
            CreateTable(
                "dbo.Parkings",
                c => new
                    {
                        ParkingId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ParkingId);
            
            CreateTable(
                "dbo.MiejsceParkingowes",
                c => new
                    {
                        MiejsceParkingoweId = c.Int(nullable: false, identity: true),
                        NrMiejsca = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Parking_ParkingId = c.Int(),
                    })
                .PrimaryKey(t => t.MiejsceParkingoweId)
                .ForeignKey("dbo.Parkings", t => t.Parking_ParkingId)
                .Index(t => t.Parking_ParkingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezerwacjas", "UzytkownikId", "dbo.Uzytkownik");
            DropForeignKey("dbo.Rezerwacjas", "P_ParkingId", "dbo.Parkings");
            DropForeignKey("dbo.MiejsceParkingowes", "Parking_ParkingId", "dbo.Parkings");
            DropIndex("dbo.MiejsceParkingowes", new[] { "Parking_ParkingId" });
            DropIndex("dbo.Rezerwacjas", new[] { "P_ParkingId" });
            DropIndex("dbo.Rezerwacjas", new[] { "UzytkownikId" });
            DropTable("dbo.MiejsceParkingowes");
            DropTable("dbo.Parkings");
            DropTable("dbo.Rezerwacjas");
            DropTable("dbo.Uzytkownik");
        }
    }
}

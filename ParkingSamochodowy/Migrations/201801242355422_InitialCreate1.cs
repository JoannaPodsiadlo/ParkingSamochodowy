namespace ParkingSamochodowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Uzytkownik", newName: "Uzytkownicy");
            RenameTable(name: "dbo.Rezerwacjas", newName: "Rezerwacje");
            RenameTable(name: "dbo.Parkings", newName: "Parkingi");
            RenameTable(name: "dbo.MiejsceParkingowes", newName: "Miejsca Parkingowe");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Miejsca Parkingowe", newName: "MiejsceParkingowes");
            RenameTable(name: "dbo.Parkingi", newName: "Parkings");
            RenameTable(name: "dbo.Rezerwacje", newName: "Rezerwacjas");
            RenameTable(name: "dbo.Uzytkownicy", newName: "Uzytkownik");
        }
    }
}

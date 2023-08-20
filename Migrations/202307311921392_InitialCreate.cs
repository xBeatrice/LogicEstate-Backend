namespace LogicEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        City = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ConstructionYear = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        NumberOfRooms = c.Int(nullable: false),
                        SurfaceSquareMeters = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyModels");
        }
    }
}

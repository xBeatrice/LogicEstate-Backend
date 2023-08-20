namespace LogicEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PropertyModels", newName: "HomeEntities");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.HomeEntities", newName: "PropertyModels");
        }
    }
}

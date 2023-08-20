namespace LogicEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddImagesProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyModels", "Images", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.PropertyModels", "Images");
        }
    }
}

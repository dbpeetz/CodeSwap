namespace CRNGroupApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingListItem", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingListItem", "Photo");
        }
    }
}

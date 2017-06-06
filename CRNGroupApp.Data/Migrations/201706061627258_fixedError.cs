namespace CRNGroupApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedError : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.File", name: "ListItem_ShoppingListItemId", newName: "ShoppingListItem_ShoppingListItemId");
            RenameIndex(table: "dbo.File", name: "IX_ListItem_ShoppingListItemId", newName: "IX_ShoppingListItem_ShoppingListItemId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.File", name: "IX_ShoppingListItem_ShoppingListItemId", newName: "IX_ListItem_ShoppingListItemId");
            RenameColumn(table: "dbo.File", name: "ShoppingListItem_ShoppingListItemId", newName: "ListItem_ShoppingListItemId");
        }
    }
}

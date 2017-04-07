namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        ToDoItemID = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoItems");
        }
    }
}

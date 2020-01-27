namespace ToDoTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToDo3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoes", "DueDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToDoes", "DueDate", c => c.DateTime(nullable: false));
        }
    }
}

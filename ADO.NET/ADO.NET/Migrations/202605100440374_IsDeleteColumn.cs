namespace ADO.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeleteColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsDelete");
            DropColumn("dbo.Companies", "IsDelete");
        }
    }
}

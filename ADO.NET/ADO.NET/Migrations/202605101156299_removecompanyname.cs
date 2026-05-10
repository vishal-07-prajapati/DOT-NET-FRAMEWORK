namespace ADO.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecompanyname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "CompanyName", c => c.String());
        }
    }
}

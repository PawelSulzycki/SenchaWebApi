namespace SenchaWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabaseVisitor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Visitors", "Address", c => c.String());
            AddColumn("dbo.Visitors", "PhoneNumer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Visitors", "PhoneNumer");
            DropColumn("dbo.Visitors", "Address");
        }
    }
}

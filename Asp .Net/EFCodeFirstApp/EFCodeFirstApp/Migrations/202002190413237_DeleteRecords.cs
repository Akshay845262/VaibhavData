namespace EFCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRecords : DbMigration
    {
        public override void Up()
        {
            Sql("delete from Products where ProductID=2");
            Sql("delete from Products where ProductID=3");
        }
        
        public override void Down()
        {
        }
    }
}

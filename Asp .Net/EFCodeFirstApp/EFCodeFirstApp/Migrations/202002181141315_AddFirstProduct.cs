namespace EFCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstProduct : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Products values('Tea',20.00)");
            Sql("insert into Products values('Milk',50.00)");
        }
        
        public override void Down()
        {
        }
    }
}

namespace DongTuanAnh_Lab_456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (ID, NAME) Values (1, 'Development')");
            Sql("Insert into Categories (ID, NAME) Values (2, 'Business')");
            Sql("Insert into Categories (ID, NAME) Values (3, 'Maarketing')");
        }
        
        public override void Down()
        {
        }
    }
}

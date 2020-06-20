namespace Lab456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'Marketing')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'Programing')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4, 'Medicine')");
        }
        
        public override void Down()
        {
        }
    }
}

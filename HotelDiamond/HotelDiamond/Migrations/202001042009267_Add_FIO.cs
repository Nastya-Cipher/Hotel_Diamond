namespace HotelDiamond.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_FIO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Fio", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Fio");
        }
    }
}

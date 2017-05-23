namespace MichalSewerniakZad5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paczkaGetNadawca : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Przesylkas", "Nadawca_Id", c => c.Int());
            CreateIndex("dbo.Przesylkas", "Nadawca_Id");
            AddForeignKey("dbo.Przesylkas", "Nadawca_Id", "dbo.Nadawcas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Przesylkas", "Nadawca_Id", "dbo.Nadawcas");
            DropIndex("dbo.Przesylkas", new[] { "Nadawca_Id" });
            DropColumn("dbo.Przesylkas", "Nadawca_Id");
        }
    }
}

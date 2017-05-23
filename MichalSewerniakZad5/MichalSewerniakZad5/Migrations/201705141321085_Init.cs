namespace MichalSewerniakZad5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Miasto = c.String(),
                        Ulica = c.String(),
                        NumerDomu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nadawcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Adres_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.Adres_Id)
                .Index(t => t.Adres_Id);
            
            CreateTable(
                "dbo.Odbiorcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumerTelefonu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Paczkomats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kod = c.String(),
                        Adres_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.Adres_Id)
                .Index(t => t.Adres_Id);
            
            CreateTable(
                "dbo.Przesylkas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Waga = c.Single(nullable: false),
                        Odbiorca_Id = c.Int(),
                        Paczkomat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Odbiorcas", t => t.Odbiorca_Id)
                .ForeignKey("dbo.Paczkomats", t => t.Paczkomat_Id)
                .Index(t => t.Odbiorca_Id)
                .Index(t => t.Paczkomat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Przesylkas", "Paczkomat_Id", "dbo.Paczkomats");
            DropForeignKey("dbo.Przesylkas", "Odbiorca_Id", "dbo.Odbiorcas");
            DropForeignKey("dbo.Paczkomats", "Adres_Id", "dbo.Adres");
            DropForeignKey("dbo.Nadawcas", "Adres_Id", "dbo.Adres");
            DropIndex("dbo.Przesylkas", new[] { "Paczkomat_Id" });
            DropIndex("dbo.Przesylkas", new[] { "Odbiorca_Id" });
            DropIndex("dbo.Paczkomats", new[] { "Adres_Id" });
            DropIndex("dbo.Nadawcas", new[] { "Adres_Id" });
            DropTable("dbo.Przesylkas");
            DropTable("dbo.Paczkomats");
            DropTable("dbo.Odbiorcas");
            DropTable("dbo.Nadawcas");
            DropTable("dbo.Adres");
        }
    }
}

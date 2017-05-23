namespace MichalSewerniakZad5.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MichalSewerniakZad5.Models.PostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MichalSewerniakZad5.Models.PostContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Nadawcy.AddOrUpdate(
                p => p.Nazwisko,
                new Nadawca
                {
                    Imie = "Michal",
                    Nazwisko = "Sewerniak",
                    Adres = new Adres { Miasto = "Wroclaw", NumerDomu = "7", Ulica = "Nie" },
                },
                new Nadawca
                {
                    Imie = "Milena",
                    Nazwisko = "Lukasik",
                    Adres = new Adres { Miasto = "Wroclaw", NumerDomu = "3c", Ulica = "Czekoladowa" },
                });

            context.Paczkomaty.AddOrUpdate(
                p => p.Kod, 
                new Paczkomat
                {
                    Kod = "WRO777",
                    Adres = new Adres { Miasto = "Wroclaw",Ulica = "Parkowa",NumerDomu = "17b"}
                },
                new Paczkomat
                {
                    Kod = "POZ423",
                    Adres = new Adres { Miasto = "Poznan" , Ulica = "Glowna" , NumerDomu = "44"}
                });

            context.Odbiorcy.AddOrUpdate(
                p => p.NumerTelefonu,new Odbiorca
                {
                    NumerTelefonu = "534-174-111"
                });
        }
    }
}

/*
 * new Przesylka {
                        Odbiorca =  new Odbiorca { NumerTelefonu = "666999111"}, Waga = 6.66f,
                        Paczkomat = new Paczkomat {Kod = "WRO657", Adres = new Adres {Miasto = "Wroclaw",Ulica = "Plac Solny",NumerDomu = "5c" } } } 
 */

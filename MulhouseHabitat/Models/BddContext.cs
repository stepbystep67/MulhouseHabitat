using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;// permet la creation de persistance de données


namespace MulhouseHabitat.Models
{


    public class BddContext : DbContext
    {

        public DbSet<Appartement> Appartements { get; set; }

        public DbSet<Maison> Maisons { get; set; }

        public DbSet<Logement> Logements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BddContext>());
            base.OnModelCreating(modelBuilder);

        }


    }


}
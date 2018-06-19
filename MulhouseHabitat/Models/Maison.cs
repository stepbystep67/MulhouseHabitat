using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MulhouseHabitat.Models
{


    public class Maison
    {


        private Maison maison;

        private List<Maison> maisons;

        public int Id { get; set; }

        public string Numero { get; set; }

        public string Rue { get; set; }

        public int CodePostal { get; set; }

        public string Ville { get; set; }

        public int NombrePiece { get; set; }

        public bool LibreOccupe { get; set; }


        public Maison()
        {



        }


        public Maison(int _id,string _numero,string _rue,int _codepostal,string _ville,int _nombrepiece)
        {

            this.Id = _id;
            this.NombrePiece = _nombrepiece;
            this.Numero = _numero;
            this.Rue = _rue;
            this.CodePostal = _codepostal;
            this.Ville = _ville;

        }

    }
}
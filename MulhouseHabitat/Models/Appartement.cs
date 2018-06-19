using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MulhouseHabitat.Models
{


    public class Appartement
    {


        private Appartement appartement;

        private List<Appartement> appartements;

        public int Id { get; set; }

        public string Numero { get; set; }

        public string Rue { get; set; }

        public int CodePostal { get; set; }

        public string Ville { get; set; }

        public string NombrePiece { get; set; }

        


        public Appartement()
        {



        }


        public Appartement(int _id,string _numero,string _rue,int _codepostal,string _ville,string _nombrepiece,bool _libreoccupe)
        {

            this.Id = _id;
            this.Numero = _numero;
            this.Rue = _rue;
            this.CodePostal = _codepostal;
            this.Ville = _ville;
            this.NombrePiece = _nombrepiece;
            

        }


    }


}

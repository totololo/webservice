
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.V1 {
    public class Contrat
    {
        public string Id { get; set; }
        public string nom_souscripteur { get; set; }
        //Concaténation du nom et prénom du CGP
        public String Apporteur { get; set; }
        //Numero du contrat 
        public string numero_contrat { get; set; }
        public string NomNaissance { get; set; }

        //Date de souscription au contrat 
        public DateTime date_souscription { get; set; }
        //Date de situation
        public DateTime date_situation { get; set; }

        //Nom du répresentant légale
        public string nom_representant { get; set; }
        public string type_souscription { get; set; }
        //cumul des versements 
        public float cumul_versement { get; set; }
        

    }
}


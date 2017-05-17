using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.V1
{
    public enum ClientType {PP=1 , PM=2  }
    public enum ClientCivilite { Monsieur = 1, Madame = 2 }

    public class Client
    {
        public string Id { get; set; }
        public ClientCivilite? Civilite { get; set; }
        public string Nom { get; set; }
        public string NomNaissance { get; set; }
        public string Prenom1 { get; set; }
        public string Prenom2 { get; set; }
        public string Prenom3 { get; set; }
        public ClientType Type { get; set; }

       
        public class AddClient
        {
            public ClientCivilite? Civilite { get; set; }
            public string Nom { get; set; }
            public string NomNaissance { get; set; }
            public string Prenom1 { get; set; }
            public string Prenom2 { get; set; }
            public string Prenom3 { get; set; }

            public ClientType Type { get; set; }
        }

        public class UpdateClient
        {
            public ClientCivilite? Civilite { get; set; }
            public string Nom { get; set; }
            public string NomNaissance { get; set; }
            public string Prenom1 { get; set; }
            public string Prenom2 { get; set; }
            public string Prenom3 { get; set; }
        }
    }
}

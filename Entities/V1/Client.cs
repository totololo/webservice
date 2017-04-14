using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.V1
{
    public class Client
    {
        public string Id { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string NomNaissance { get; set; }
        public string Prenom1 { get; set; }
        public string Prenom2 { get; set; }
        public string Prenom3 { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.MSQL.DWNortia
{
    public class Utilisateur
    {
        public int ID_Utilisateur { get; set; }
        public string CodeNortia { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool PasswordProvisoire { get; set; }
        public string ID_Salesforce { get; set; }
        public bool Actif { get; set; }
    }
}

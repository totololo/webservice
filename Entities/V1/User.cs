using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entities.V1
{
    public class User
    {
        public string Id { get; set; }
        public string CodeNortia { get; set; }
        public string Email { get; set; }
        public bool PasswordProvisoire { get; set; }

        public class Identification
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        public string login { get; set; }
        public string senha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "Login é obirgatório!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Email é obirgatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é obirgatório!")]
        public string Senha { get; set; }
    }
}

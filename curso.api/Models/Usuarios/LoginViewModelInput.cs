using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O Senha é Obrigatorio")]
        public string Senha { get; set; }
    }
}

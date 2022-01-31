using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Email é Obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Senha é Obrigatorio")]
        public string  Senha { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mal requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha requerido")]
        public string Senha { get; set; }

    }
}

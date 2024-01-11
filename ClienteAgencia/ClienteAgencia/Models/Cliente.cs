using System.ComponentModel.DataAnnotations;

namespace ClienteAgencia.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve ser preenchido apenas em números e ter no 11 caracteres.")]
        public string Cpf { get; set; }


        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [StringLength(20, MinimumLength = 9, ErrorMessage = "O campo Nome deve ter no mínimo 9 caracteres.")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo E-mail deve ter no mínimo 3 caracteres.")]
        public string Email { get; set; }
    }
}

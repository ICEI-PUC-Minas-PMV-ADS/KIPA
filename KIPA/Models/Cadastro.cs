using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KIPA.Models
{
    [Table("Cadastros")]
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public string Senha { get; set; }

        public int Telefone { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAcervo.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome de usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a senha do usuário")]
        public string Senha { get; set;}
    }
}

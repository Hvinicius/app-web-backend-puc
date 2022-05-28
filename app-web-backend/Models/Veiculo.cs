using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório Informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar aplaca!")]
        public string Placa { get; set; }
    }
}

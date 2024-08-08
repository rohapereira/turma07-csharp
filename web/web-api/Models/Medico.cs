using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "CRM é obrigatório")]
        [StringLength(9, ErrorMessage = "CRM deve ter no máximo 9 caracteres.")]
        public string CRM {  get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 100 caracteres.")]
        public string Nome { get; set; }
        //public List<string> Especialidades { get; set; }

        public Medico()
        {
            this.Id = 0;
            this.CRM = string.Empty;
            this.Nome = string.Empty;
        }
    }
}
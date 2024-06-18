using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraApi.Models;
public class Cliente
    {
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A idade é obrigatória")]    
    public int Idade { get; set; }

    [Required(ErrorMessage = "A data de nascimento é obrigatória")]
    public DateTime DataNascimento { get; set; }

    [MaxLength(15)]
    [Required(ErrorMessage = "O sexo é obrigatório")]
    public string Sexo { get; set; }

    [MaxLength(255)]
    [Required(ErrorMessage = "O endereço é obrigatório")]
    public string Endereco { get; set; }

    [MaxLength(50)]
    public string? Complemento { get; set; }

    [MaxLength(20)]
    [Required(ErrorMessage = "O número é obrigatório")]
    public string Numero { get; set; }

    [Required(ErrorMessage = "O CEP é obrigatório")]
    public int CEP { get; set; }

    [MaxLength(255)]
    [Required(ErrorMessage = "A cidade é obrigatória")]
    public string Cidade { get; set; }

    [MaxLength(2)]
    [Required(ErrorMessage = "O estado é obrigatório")]
    public string Estado { get; set; }

    [MaxLength(20)]
    public string? Fone { get; set; }
}
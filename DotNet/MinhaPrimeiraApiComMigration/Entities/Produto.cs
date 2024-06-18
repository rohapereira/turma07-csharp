namespace MinhaPrimeiraApiComMigration.Entities;
public class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public decimal Preco { get; set; }

    public bool Inativo { get; set; }

    public int FornecedorId { get; set; }

    public virtual Fornecedor Fornecedor { get; set; } // Propriedade de navegação
}
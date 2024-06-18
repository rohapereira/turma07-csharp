namespace MinhaPrimeiraApiComMigration.Entities;
public class Fornecedor
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public DateTime DataCadastro { get; set; }

    public virtual IEnumerable<Produto> Produtos { get; set; }

    public Fornecedor()
    {
        DataCadastro = DateTime.Now;
    }
}
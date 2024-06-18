namespace MinhaPrimeiraApiComMigration.Entities;
public class Estoque
{
    public int Id { get; set; }

    public decimal Quantidade { get; set; }

    public int ProdutoId { get; set; }

    public virtual Produto Produto { get; set; }
}
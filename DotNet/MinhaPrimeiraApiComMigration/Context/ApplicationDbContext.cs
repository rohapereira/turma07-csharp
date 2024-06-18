using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApiComMigration.Entities;

namespace MinhaPrimeiraApi.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Estoque> Estoques { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(e => e.Id); // Indico que o meu produto tem uma chave primária

        modelBuilder.Entity<Fornecedor>().HasKey(e => e.Id);

        modelBuilder.Entity<Estoque>().HasKey(e => e.Id);

        modelBuilder.Entity<Produto>().Property(e => e.Preco).HasPrecision(18, 5);

        modelBuilder.Entity<Estoque>().Property(e => e.Quantidade).HasPrecision(18, 5);

        modelBuilder
            .Entity<Produto>()
            .HasOne(e => e.Fornecedor) // Um produto tem um fornecedor
            .WithMany(e => e.Produtos) // Um fornecedor tem vários produtos
            .HasForeignKey(e => e.FornecedorId) // Indico que o produto tem uma relação com o fornecedor
            .IsRequired(); // O produto precisa ter um fornecedor

        modelBuilder
            .Entity<Estoque>()
            .HasOne(e => e.Produto) // O estoque tem um produto
            .WithOne() // Um produto não necessita de um estoque
            .HasForeignKey<Estoque>(e => e.ProdutoId) //Indico que o estoque tem uma relação com o produto
            .IsRequired(); // É obrigatório existir um produto

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("DefaultConnection");

        base.OnConfiguring(optionsBuilder);
    }
}
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Context;
using MinhaPrimeiraApiComMigration.Entities;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApiComMigration.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProdutoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<Produto>>> ObterTodos() => Ok(await _context.Produtos.Include(e => e.Fornecedor).ToListAsync());

    [HttpPost("gravar-produto")]
    public async Task<ActionResult<Produto>> GravarProduto([FromBody] Produto model)
    {
        try
        {
            if (model == null)
            return BadRequest("Não é possível gravar o produto, verifique os dados fornecidos.");

            if (model.Preco == 0)
                return BadRequest("Não é possível gravar um produto com preço zerado.");

            if (!await VerificarExistenciaFornecedor(model.FornecedorId))
                return BadRequest($"Não foi possível localizar o fornecedor de código {model.FornecedorId}");

            var novoProduto = new Produto 
            {
                Nome = model.Nome,
                Preco = model.Preco,
                Inativo = model.Inativo,
                FornecedorId = model.FornecedorId
            };

            _context.Produtos.Add(novoProduto);

            await _context.SaveChangesAsync();

            return Ok(novoProduto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private async Task<bool> VerificarExistenciaFornecedor(int id)
    {
        try
        {
            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(e => e.Id == id);

            if (fornecedor == null)
                return false;

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpPut("atualizar-produto/{id}")]
    public async Task<ActionResult<Produto>> AtualizarProduto(int id, [FromBody] Produto model)
    {
        try
        {
            if (model == null)
                return BadRequest("Dados do produto não fornecidos.");

            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
                return NotFound("Produto não encontrado.");

            if (!await VerificarExistenciaFornecedor(model.FornecedorId))
                return BadRequest($"Não foi possível localizar o fornecedor de código {model.FornecedorId}");

            produto.Nome = model.Nome;
            produto.Preco = model.Preco;
            produto.Inativo = model.Inativo;
            produto.FornecedorId = model.FornecedorId;

            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();

            return Ok(produto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("excluir-produto/{id}")]
    public async Task<ActionResult> ExcluirProduto(int id)
    {
        try
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
                return NotFound("Produto não encontrado.");

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok("Produto excluído com sucesso.");
        }
        catch (Exception)
        {
            throw;
        }
    }
}
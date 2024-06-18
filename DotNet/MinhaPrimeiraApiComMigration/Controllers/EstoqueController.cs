using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Context;
using MinhaPrimeiraApiComMigration.Entities;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApiComMigration.Controllers;

[ApiController]
[Route("[controller]")]
public class EstoqueController : ControllerBase
{

    private readonly ApplicationDbContext _context;

    public EstoqueController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public async Task<ActionResult<List<Estoque>>> ObterTodos() => Ok(await _context.Estoques.Include(e => e.Produto).ToListAsync());

    [HttpPost("gravar-estoque")]
    public async Task<ActionResult<Estoque>> GravarEstoque([FromBody] Estoque model)
    {
        try
        {
            if (model == null)
            return BadRequest("Não foi possível gravar o estoque, verifique os parâmetros.");

            if (model.ProdutoId == 0)
                return BadRequest("Não é possível gravar um esqtoque sem código de produto.");

            if (!await VerificarExistenciaProduto(model.ProdutoId))
                return BadRequest($"Não foi possível localizar o produto de código {model.ProdutoId}.");

            var novoEstoque = new Estoque
            {
                ProdutoId = model.ProdutoId,
                Quantidade = model.Quantidade
            };

            _context.Estoques.Add(novoEstoque);

            await _context.SaveChangesAsync();

            return Ok(novoEstoque);
        }
        catch (Exception)
        {
            throw;
        }
        
    }

    private async Task<bool> VerificarExistenciaProduto(int id)
    {
        try
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(e => e.Id == id);

            if (produto == null)
                return false;

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpPut("atualizar-estoque/{id}")]
    public async Task<ActionResult<Estoque>> AtualizarEstoque(int id, [FromBody] Estoque model)
    {
        try
        {
            if (model == null)
                return BadRequest("Dados do estoque não fornecidos.");

            var estoque = await _context.Estoques.FindAsync(id);

            if (estoque == null)
                return NotFound("Estoque não encontrado.");

            if (!await VerificarExistenciaProduto(model.ProdutoId))
                return BadRequest($"Não foi possível localizar o produto de código {model.ProdutoId}.");

            estoque.ProdutoId = model.ProdutoId;
            estoque.Quantidade = model.Quantidade;

            _context.Estoques.Update(estoque);
            await _context.SaveChangesAsync();

            return Ok(estoque);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("excluir-estoque/{id}")]
    public async Task<ActionResult> ExcluirEstoque(int id)
    {
        try
        {
            var estoque = await _context.Estoques.FindAsync(id);

            if (estoque == null)
                return NotFound("Estoque não encontrado.");

            _context.Estoques.Remove(estoque);
            await _context.SaveChangesAsync();

            return Ok("Estoque excluído com sucesso.");
        }
        catch (Exception)
        {
            throw;
        }
    }
}
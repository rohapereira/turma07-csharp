using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Context;
using MinhaPrimeiraApiComMigration.Entities;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApiComMigration.Controllers;

[ApiController]
[Route("[controller]")]
public class FornecedorController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public FornecedorController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<Fornecedor>>> ObterTodos() => Ok(await _context.Fornecedores.Include(e => e.Produtos).ToListAsync());

    [HttpPost("gravar-fornecedor")]
    public async Task<ActionResult<Fornecedor>> GravarFornecedor(string nome)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(nome))
                return BadRequest("Não é possível gravar um fornecedor sem nome.");

            var novoFornecedor = new Fornecedor { Nome = nome };

            if (novoFornecedor == null)
                return BadRequest();

            _context.Fornecedores.Add(novoFornecedor);

            await _context.SaveChangesAsync();

            return Ok(novoFornecedor);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpPut("atualizar-fornecedor/{id}")]
    public async Task<ActionResult<Fornecedor>> AtualizarFornecedor(int id, string nome)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(nome))
                return BadRequest("Nome do fornecedor não pode ser vazio.");

            var fornecedor = await _context.Fornecedores.FindAsync(id);

            if (fornecedor == null)
                return NotFound("Fornecedor não encontrado.");

            fornecedor.Nome = nome;

            _context.Fornecedores.Update(fornecedor);

            await _context.SaveChangesAsync();

            return Ok(fornecedor);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("excluir-fornecedor/{id}")]
    public async Task<ActionResult> ExcluirFornecedor(int id)
    {
        try
        {
            var fornecedor = await _context.Fornecedores.FindAsync(id);

            if (fornecedor == null)
                return NotFound("Fornecedor não encontrado.");

            _context.Fornecedores.Remove(fornecedor);

            await _context.SaveChangesAsync();

            return Ok("Fornecedor excluído com sucesso.");
        }
        catch (Exception)
        {
            throw;
        }
    }        
}
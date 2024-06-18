using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Context;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ClienteController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("obter-todos")]
    public async Task<ActionResult<Cliente>> ObterTodos() => Ok(await _context.Clientes.ToListAsync());

    [HttpPost("gravar-cliente")]
    public async Task<ActionResult<Cliente>> GravarCliente([FromBody] Cliente model)
    {
        if (!ModelState.IsValid)
            return BadRequest();

         _context.Clientes.Add(model);

         await _context.SaveChangesAsync();

         return Ok(model);
    }

    [HttpPut("atualizar-cliente/{id:int}")]
    public async Task<ActionResult<Cliente>> AtualizarClienteExistente(int id, Cliente model)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null)
            return NotFound();

        cliente.Nome = model.Nome;
        cliente.Idade = model.Idade;
        cliente.DataNascimento = model.DataNascimento;
        cliente.Sexo = model.Sexo;
        cliente.Endereco = model.Endereco;
        cliente.Complemento = model.Complemento;
        cliente.Numero = model.Numero;
        cliente.CEP = model.CEP;
        cliente.Cidade = model.Cidade;
        cliente.Estado = model.Estado;
        cliente.Fone = model.Fone;

        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();

        return Ok(model);
    }

    [HttpDelete("deletar-cliente/{id:int}")]
    public async Task<ActionResult> DeletarCliente(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente == null)
            return BadRequest();

        _context.Clientes.Remove(cliente);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}
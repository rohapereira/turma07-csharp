using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Context;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly string connectionString = "Server=DESKTOP-LQE5S1B,1433;Database=DotNet;User Id=sa; Password=epilef; TrustServerCertificate=True;";

    public ClienteController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("obter-todos")]
    public async Task<ActionResult<Cliente>> ObterTodos()
    {
        var listaClientes = new List<Cliente>();

        try
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";

                SqlCommand command = new SqlCommand(query,connection);

                await connection.OpenAsync();

                using(SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while(await reader.ReadAsync())
                    {
                        var cliente = new Cliente
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Idade = reader.GetInt32(2),
                            DataNascimento = reader.GetDateTime(3),
                            Sexo = reader.GetString(4),
                            Endereco = reader.GetString(5),
                            Complemento = !reader.IsDBNull(6) ? reader.GetString(6) : null,
                            Numero = reader.GetString(7),
                            CEP = reader.GetInt32(8),
                            Cidade = reader.GetString(9),
                            Estado = reader.GetString(10),
                            Fone = !reader.IsDBNull(11) ? reader.GetString(11) : null,
                        };

                        if(cliente != null)
                            listaClientes.Add(cliente);
                    }
                }
            }

            return Ok(listaClientes);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpPost("gravar-cliente")]
    public async Task<ActionResult> GravarCliente([FromBody] Cliente model)
    {
        string query = "INSERT INTO Clientes VALUES (@Nome, @Idade, @DataNascimento, @Sexo, @Endereco, @Complemento, @Numero, @CEP, @Cidade, @Estado, @Fone)";

        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            await connection.OpenAsync();

            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", model.Nome);
                command.Parameters.AddWithValue("@Idade", model.Idade);
                command.Parameters.AddWithValue("@DataNascimento", model.DataNascimento);
                command.Parameters.AddWithValue("@Sexo", model.Sexo);
                command.Parameters.AddWithValue("@Endereco", model.Endereco);
                command.Parameters.AddWithValue("@Complemento", model.Complemento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Numero", model.Numero);
                command.Parameters.AddWithValue("@CEP", model.CEP);
                command.Parameters.AddWithValue("@Cidade", model.Cidade);
                command.Parameters.AddWithValue("@Estado", model.Estado);
                command.Parameters.AddWithValue("@Fone", model.Fone ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
            }
        }

        return NoContent();
    }

    [HttpPut("atualizar-cliente/{id:int}")]
    public async Task<ActionResult> AtualizarClienteExistente(int id, Cliente model)
    {
        if (!await VerificarExistenciaCliente(id))
            return NotFound();

        string query = "UPDATE Clientes SET Nome = @Nome, Idade = @Idade, DataNascimento = @DataNascimento, Sexo = @Sexo, Endereco = @Endereco, Complemento = @Complemento, Numero = @Numero, CEP = @CEP, Cidade = @Cidade, Estado = @Estado, Fone = @Fone WHERE Id = @Id";

        using SqlConnection connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", model.Nome);
                command.Parameters.AddWithValue("@Idade", model.Idade);
                command.Parameters.AddWithValue("@DataNascimento", model.DataNascimento);
                command.Parameters.AddWithValue("@Sexo", model.Sexo);
                command.Parameters.AddWithValue("@Endereco", model.Endereco);
                command.Parameters.AddWithValue("@Complemento", model.Complemento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Numero", model.Numero);
                command.Parameters.AddWithValue("@CEP", model.CEP);
                command.Parameters.AddWithValue("@Cidade", model.Cidade);
                command.Parameters.AddWithValue("@Estado", model.Estado);
                command.Parameters.AddWithValue("@Fone", model.Fone ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Id", id);

                int result = await command.ExecuteNonQueryAsync();

        return result > 0 ? NoContent() : BadRequest();
    }

    private async Task<bool> VerificarExistenciaCliente(int id)
    {
        string query = "SELECT COUNT(*) FROM Clientes WHERE Id = @Id";

        int count = 0;

        using SqlConnection connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                count = (int)await command.ExecuteScalarAsync();

        return count > 0;
    } 

    [HttpDelete("deletar-cliente/{id:int}")]
    public async Task<ActionResult> DeletarCliente(int id)
    {
        if (!await VerificarExistenciaCliente(id))
            return NotFound();

        string query = "DELETE FROM Clientes WHERE Id = @Id";

        using SqlConnection connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                await command.ExecuteNonQueryAsync();

        return NoContent();
    }
}
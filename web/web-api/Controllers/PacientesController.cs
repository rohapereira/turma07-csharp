using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using web_api.Models;

namespace web_api.Controllers
{
    public class PacientesController : ApiController
    {
        // GET: api/Pacientes
        public IHttpActionResult Get()
        {
            List<Models.Paciente> pacientes = new List<Models.Paciente>();

            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select codigo, nome, datanascimento from paciente";
                    cmd.Connection = conn;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Paciente paciente = new Models.Paciente();

                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.DataNascimento = (DateTime)dr["datanascimento"];

                            pacientes.Add(paciente);
                        }
                    }
                }
            }

            return Ok(pacientes);
        }

        // GET: api/Pacientes/5
        public IHttpActionResult Get(int id)
        {
            Models.Paciente paciente = new Models.Paciente();

            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"select codigo, nome, datanascimento from paciente where codigo = {id};";
                    cmd.Connection = conn;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.DataNascimento = (DateTime)dr["datanascimento"];
                        }
                        else
                            return NotFound();
                    }
                }
            }

            return Ok(paciente);
        }

        // POST: api/Pacientes
        public IHttpActionResult Post(Models.Paciente paciente)
        {
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    string dataNascimentoFormatada = paciente.DataNascimento.ToString("yyyy-MM-dd");

                    cmd.CommandText = $"insert into paciente (nome,datanascimento) values ('{paciente.Nome}','{dataNascimentoFormatada}'); select convert(int,SCOPE_IDENTITY()) as codigo";
                    cmd.Connection = conn;
                    paciente.Codigo = (int)cmd.ExecuteScalar();
                }
            }

            if (paciente.Codigo == 0)
                return BadRequest();

            return Ok(paciente);
        }

        // PUT: api/Pacientes/5
        public IHttpActionResult Put(int id, [FromBody] Models.Paciente paciente)
        {
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    string dataNascimentoFormatada = paciente.DataNascimento.ToString("yyyy-MM-dd");

                    cmd.CommandText = $"update paciente set nome = '{paciente.Nome}', datanascimento = '{dataNascimentoFormatada}' where codigo = {id}";
                    cmd.Connection = conn;

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        return NotFound();
                    }
                }
            }

            return Ok($"Paciente {id} alterado com sucesso!");
        }

        // DELETE: api/Pacientes/5
        public IHttpActionResult Delete(int id)
        {
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"delete from paciente where codigo = {id}";
                    cmd.Connection = conn;

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        return NotFound();
                    }
                }
            }

            return Ok($"Paciente {id} foi removido com sucesso!");
        }
    }
}

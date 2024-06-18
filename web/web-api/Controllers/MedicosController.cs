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
    public class MedicosController : ApiController
    {
        // GET: api/Medicos
        public IHttpActionResult Get()
        {
            List<Models.Medico> medicos = new List<Models.Medico>();

            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT crm, nome FROM medico";
                    cmd.Connection = conn;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Medico medico = new Models.Medico();

                            medico.CRM = (string)dr["crm"];
                            medico.Nome = (string)dr["nome"];

                            medicos.Add(medico);
                        }
                    }
                }
            }

            return Ok(medicos);
        }

        // GET: api/Medicos/5
        [Route("api/medicos/{crm}")]
        public IHttpActionResult Get(string crm) // Como corrigir para pesquisar por CRM?
        {
            Models.Medico medico = new Models.Medico();

            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select crm, nome from medico where crm = @crm;";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@crm", crm);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            medico.CRM = (string)dr["crm"];
                            medico.Nome = (string)dr["nome"];
                        }
                        else
                            return NotFound();
                    }
                }
            }

            return Ok(medico);
        }

        // POST: api/Medicos
        public IHttpActionResult Post(Models.Medico medico)
        {
            int linhasAfetadas = 0;
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string sql = $"insert into medico(crm, nome) values('{medico.CRM}', '{medico.Nome}')";

                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandText = sql;
                    comando.Connection = conexao;
                    linhasAfetadas = comando.ExecuteNonQuery();
                }
            }

            if (linhasAfetadas == 0)
                return InternalServerError();

            return Ok(medico);
        }

        // PUT: api/Medicos/5
        public IHttpActionResult Put(int id, [FromBody] Models.Medico medico) // Como alterar médico por CRM?
        {
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"update medico set crm = '{medico.CRM}', nome = '{medico.Nome}' where codigo = {id}";
                    cmd.Connection = conn;

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        return NotFound();
                    }
                }
            }

            return Ok($"Médico de CRM {id} alterado com sucesso!");
        }

        // DELETE: api/Medicos/5
        public IHttpActionResult Delete(int id) // Como remover médico por CRM?
        {
            string connectionString = @"Server=DESKTOP-LQE5S1B\MSSQLSERVER,1433;Database=consultorio;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"delete from medico where crm = {id}";
                    cmd.Connection = conn;

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        return NotFound();
                    }
                }
            }

            return Ok($"Médico de CRM {id} foi removido com sucesso!");
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System;

namespace web_api.Repositories.SQLServer
{
    public class Paciente
    {
        //private readonly string connectionString;
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;
        private readonly string cacheKey = "pacienteCache";
        private readonly List<Models.Paciente> cacheItem;
        //public Paciente(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        public Paciente(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _cmd = new SqlCommand();
            _cmd.Connection = _conn;
        }

        public async Task<List<Models.Paciente>> GetAll()
        {
            if (cacheItem != null)
            {
                return cacheItem;
            }

            List<Models.Paciente> pacientes = new List<Models.Paciente>();

            //using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (_conn)
            {
                await _conn.OpenAsync();

                //using (SqlCommand cmd = new SqlCommand())
                using (_cmd)
                {
                    //cmd.Connection = conn;
                    _cmd.CommandText = "select codigo, datanascimento, nome from paciente;";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Paciente paciente = new Models.Paciente();

                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.DataNascimento = (DateTime)dr["datanascimento"];

                            pacientes.Add(paciente);
                        }
                    }
                }
                Util.Cache.setCache(cacheKey, pacientes, 50);
            }
            return pacientes;
        }

        public async Task<Models.Paciente> GetById(int id)
        {
            Models.Paciente paciente = null;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select codigo, datanascimento, nome from paciente where codigo = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            paciente = new Models.Paciente();

                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.DataNascimento = (DateTime)dr["datanascimento"];
                        }
                    }
                }
            }
            return paciente;
        }

        public async Task<bool> Add(Models.Paciente paciente)
        {
            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    string dataNascimentoFormatada = paciente.DataNascimento.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "insert into paciente (nome,datanascimento) values (@nome,@datanascimento);select convert(int,SCOPE_IDENTITY()) as codigo";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = paciente.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@datanascimento", SqlDbType.Date)).Value = dataNascimentoFormatada;

                    paciente.Codigo = (int)await _cmd.ExecuteScalarAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return paciente.Codigo != 0 ? true : false;
        }

        public async Task<bool> Update(Models.Paciente paciente)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    string dataNascimentoFormatada = paciente.DataNascimento.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "update paciente set nome = @nome, datanascimento = @datanascimento where codigo = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = paciente.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@datanascimento", SqlDbType.Date)).Value = dataNascimentoFormatada;
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = paciente.Codigo;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas != 0;
        }

        public async Task<bool> DeleteById(int id)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "delete from paciente where codigo = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas == 1;
        }
    }
}
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System;
using web_api.Models;

namespace web_api.Repositories.SQLServer
{
    public class Medicamento
    {
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;
        private readonly string cacheKey = "medicamentoCache";
        private readonly List<Models.Medicamento> cacheItem;

        public Medicamento(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _cmd = new SqlCommand
            {
                Connection = _conn
            };
        }

        public async Task<List<Models.Medicamento>> Select()
        {
            if (cacheItem != null)
            {
                return cacheItem;
            }

            List<Models.Medicamento> medicamentos = new List<Models.Medicamento>();

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT id, nome, datafabricacao, datavencimento FROM medicamento";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Medicamento medicamento = new Models.Medicamento();

                            medicamento.Id = (int)dr["id"];
                            medicamento.Nome = dr["nome"].ToString();
                            medicamento.DataDeFabricacao = Convert.ToDateTime(dr["datafabricacao"]);
                            if (!(dr["datavencimento"] is DBNull))
                                medicamento.DataDeVencimento = Convert.ToDateTime(dr["datavencimento"]);

                            medicamentos.Add(medicamento);
                        }
                    }
                }
                Util.Cache.setCache(cacheKey, medicamentos, 50);
            }
            return medicamentos;
        }

        public async Task<Models.Medicamento> SelectById(int id)
        {
            Models.Medicamento medicamento = null;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, datafabricacao, datavencimento from medicamento where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            medicamento = new Models.Medicamento();

                            medicamento.Id = (int)dr["id"];
                            medicamento.Nome = dr["nome"].ToString();
                            medicamento.DataDeFabricacao = Convert.ToDateTime(dr["datafabricacao"]);
                            if (!(dr["datavencimento"] is DBNull))
                                medicamento.DataDeVencimento = Convert.ToDateTime(dr["datavencimento"]);
                        }
                    }
                }
            }
            return medicamento;
        }

        public async Task<List<Models.Medicamento>> GetByName(string nome)
        {
            List<Models.Medicamento> medicamentos = new List<Models.Medicamento>();

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, datafabricacao, datavencimento from medicamento where nome like @nome;";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = $"%{nome}%";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Medicamento medicamento = new Models.Medicamento();

                            medicamento.Id = (int)dr["id"];
                            medicamento.Nome = dr["nome"].ToString();
                            medicamento.DataDeFabricacao = Convert.ToDateTime(dr["datafabricacao"]);
                            if (!(dr["datavencimento"] is DBNull))
                                medicamento.DataDeVencimento = Convert.ToDateTime(dr["datavencimento"]);

                            medicamentos.Add(medicamento);
                        }
                    }
                }
            }
            return medicamentos;
        }

        public async Task<bool> Add(Models.Medicamento medicamento)
        {
            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    string dataFabricacaoFormatada = medicamento.DataDeFabricacao.ToString("yyyy-MM-dd");
                    string dataVencimentoFormatada = medicamento.DataDeVencimento?.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "insert into medicamento (nome,datafabricacao, datavencimento) values (@nome,@datafabricacao,@datavencimento);select convert(int,SCOPE_IDENTITY()) as id";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = medicamento.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@datafabricacao", SqlDbType.Date)).Value = dataFabricacaoFormatada;
                    if (medicamento.DataDeVencimento != null)
                        _cmd.Parameters.Add(new SqlParameter("@datavencimento", SqlDbType.Date)).Value = dataVencimentoFormatada;
                    else
                        _cmd.Parameters.Add(new SqlParameter("@datavencimento", SqlDbType.Date)).Value = DBNull.Value;

                    medicamento.Id = (int)await _cmd.ExecuteScalarAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return medicamento.Id != 0 ? true : false;
        }

        public async Task<bool> Update(Models.Medicamento medicamento)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    string dataFabricacaoFormatada = medicamento.DataDeFabricacao.ToString("yyyy-MM-dd");
                    string dataVencimentoFormatada = medicamento.DataDeVencimento?.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "update medicamento set nome = @nome, datafabricacao = @datafabricacao, datavencimento = @datavencimento where id = @id;";

                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = medicamento.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@datafabricacao", SqlDbType.Date)).Value = dataFabricacaoFormatada;
                    if (medicamento.DataDeVencimento != null)
                        _cmd.Parameters.Add(new SqlParameter("@datavencimento", SqlDbType.Date)).Value = dataVencimentoFormatada;
                    else
                        _cmd.Parameters.Add(new SqlParameter("@datavencimento", SqlDbType.Date)).Value = DBNull.Value;
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = medicamento.Id;

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
                    _cmd.CommandText = "delete from medicamento where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas == 1;
        }
    }
}
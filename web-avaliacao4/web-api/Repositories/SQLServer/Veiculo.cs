using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace web_api.Repositories.SQLServer
{
    public class Veiculo
    {
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;

        public Veiculo(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _cmd = new SqlCommand
            {
                Connection = _conn
            };
        }

        public List<Models.Veiculo> SelectAll()
        {
            List<Models.Veiculo> veiculos = new List<Models.Veiculo>();

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT Id, Marca, Nome, AnoModelo, DataFabricacao, Valor, Opcionais FROM Veiculos";

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Veiculo veiculo = new Models.Veiculo();

                            veiculo.Id = (int)dr["Id"];
                            veiculo.Marca = dr["Marca"].ToString();
                            veiculo.Nome = dr["Nome"].ToString();
                            veiculo.AnoModelo = (int)dr["AnoModelo"];
                            veiculo.DataFabricacao = Convert.ToDateTime(dr["DataFabricacao"]);
                            veiculo.Valor = (decimal)dr["Valor"];
                            if (!(dr["Opcionais"] is DBNull))
                                veiculo.Opcionais = (dr["Opcionais"].ToString());

                            veiculos.Add(veiculo);
                        }
                    }
                }
            }

            return veiculos;
        }

        public Models.Veiculo SelectById(int id)
        {
            Models.Veiculo veiculo = null;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT Id, Marca, Nome, AnoModelo, DataFabricacao, Valor, Opcionais FROM Veiculos where Id = @Id;";

                    _cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            veiculo = new Models.Veiculo();

                            veiculo.Id = (int)dr["Id"];
                            veiculo.Marca = dr["Marca"].ToString();
                            veiculo.Nome = dr["Nome"].ToString();
                            veiculo.AnoModelo = (int)dr["AnoModelo"];
                            veiculo.DataFabricacao = Convert.ToDateTime(dr["DataFabricacao"]);
                            veiculo.Valor = (decimal)dr["Valor"];
                            if (!(dr["Opcionais"] is DBNull))
                                veiculo.Opcionais = (dr["Opcionais"].ToString());
                        }
                    }
                }
            }
            return veiculo;
        }

        public List<Models.Veiculo> SelectByName(string Nome)
        {
            List<Models.Veiculo> veiculos = new List<Models.Veiculo>();

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT Id, Marca, Nome, AnoModelo, DataFabricacao, Valor, Opcionais FROM Veiculos where Nome like @Nome;";

                    _cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = $"%{Nome}%";

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Veiculo veiculo = new Models.Veiculo();

                            veiculo.Id = (int)dr["Id"];
                            veiculo.Marca = dr["Marca"].ToString();
                            veiculo.Nome = dr["Nome"].ToString();
                            veiculo.AnoModelo = (int)dr["AnoModelo"];
                            veiculo.DataFabricacao = Convert.ToDateTime(dr["DataFabricacao"]);
                            veiculo.Valor = (decimal)dr["Valor"];
                            if (!(dr["Opcionais"] is DBNull))
                                veiculo.Opcionais = (dr["Opcionais"].ToString());

                            veiculos.Add(veiculo);
                        }
                    }
                }
            }
            return veiculos;
        }

        public bool Add(Models.Veiculo veiculo)
        {
            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    string dataFabricacaoFormatada = veiculo.DataFabricacao.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "INSERT INTO Veiculos (Marca, Nome, AnoModelo, DataFabricacao, Valor, Opcionais) values (@Marca, @Nome, @AnoModelo, @DataFabricacao, @Valor, @Opcionais);select convert(int,SCOPE_IDENTITY()) as id";

                    _cmd.Parameters.Add(new SqlParameter("@Marca", SqlDbType.VarChar)).Value = veiculo.Marca;
                    _cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = veiculo.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@AnoModelo", SqlDbType.Int)).Value = veiculo.AnoModelo;
                    _cmd.Parameters.Add(new SqlParameter("@DataFabricacao", SqlDbType.Date)).Value = dataFabricacaoFormatada;
                    _cmd.Parameters.Add(new SqlParameter("@Valor", SqlDbType.Decimal)).Value = veiculo.Valor;
                    if (veiculo.Opcionais != null)
                        _cmd.Parameters.Add(new SqlParameter("@Opcionais", SqlDbType.VarChar)).Value = veiculo.Opcionais;
                    else
                        _cmd.Parameters.Add(new SqlParameter("@Opcionais", SqlDbType.VarChar)).Value = DBNull.Value;

                    veiculo.Id = (int)_cmd.ExecuteScalar();
                }
            }
            return veiculo.Id != 0 ? true : false;
        }

        public bool Update(int id, Models.Veiculo veiculo)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    string dataFabricacaoFormatada = veiculo.DataFabricacao.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "UPDATE Veiculos SET Marca = @Marca, Nome = @Nome, AnoModelo = @AnoModelo, DataFabricacao = @DataFabricacao, Valor = @Valor, Opcionais = @Opcionais where Id = @Id;";

                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = veiculo.Id;
                    _cmd.Parameters.Add(new SqlParameter("@Marca", SqlDbType.VarChar)).Value = veiculo.Marca;
                    _cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = veiculo.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@AnoModelo", SqlDbType.Int)).Value = veiculo.AnoModelo;
                    _cmd.Parameters.Add(new SqlParameter("@DataFabricacao", SqlDbType.Date)).Value = dataFabricacaoFormatada;
                    _cmd.Parameters.Add(new SqlParameter("@Valor", SqlDbType.Decimal)).Value = veiculo.Valor;
                    if (veiculo.Opcionais != null)
                        _cmd.Parameters.Add(new SqlParameter("@Opcionais", SqlDbType.VarChar)).Value = veiculo.Opcionais;
                    else
                        _cmd.Parameters.Add(new SqlParameter("@Opcionais", SqlDbType.VarChar)).Value = DBNull.Value;

                    linhasAfetadas = _cmd.ExecuteNonQuery();
                }
            }

            return linhasAfetadas != 0;
        }

        public bool Delete(int id)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "DELETE FROM Veiculos where Id = @Id;";
                    _cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = _cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas == 1;
        }
    }
}
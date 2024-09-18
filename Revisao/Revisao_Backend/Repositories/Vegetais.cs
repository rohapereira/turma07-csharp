using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Revisao_Backend.Repositories
{
    public class Vegetais
    {
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;

        public Vegetais(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _cmd = new SqlCommand
            {
                Connection = _conn
            };
        }
        
        public List<Models.Vegetais> Select()
        {
            List<Models.Vegetais> vegetais = new List<Models.Vegetais>();

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, preco,validade from vegetais;";

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Vegetais vegetal = new Models.Vegetais();
                            vegetal.Id = (int)dr["id"];
                            vegetal.Nome = dr["nome"].ToString();
                            vegetal.Preco = (decimal)(dr["preco"]);
                            vegetal.Validade = Convert.ToDateTime(dr["validade"]);

                            vegetais.Add(vegetal);
                        }
                    }
                }
            }
            return vegetais;
        }

        public Models.Vegetais SelectById(int id)
        {
            Models.Vegetais vegetal = null;
            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, preco,validade from vegetais where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            vegetal = new Models.Vegetais();

                            vegetal.Id = (int)dr["id"];
                            vegetal.Nome = dr["nome"].ToString();
                            vegetal.Preco = (decimal)(dr["preco"]);
                            vegetal.Validade = Convert.ToDateTime(dr["validade"]);
                        }
                    }
                }
            }
            return vegetal;
        }

        public List<Models.Vegetais> SelectByName(string nome)
        {
            List<Models.Vegetais> vegetais = new List<Models.Vegetais>();
            Models.Vegetais vegetal = null;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, preco,validade from vegetais where nome like @nome;";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = $"%{nome}%";

                    using (SqlDataReader dr = _cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegetal = new Models.Vegetais();
                            vegetal.Id = (int)dr["id"];
                            vegetal.Nome = dr["nome"].ToString();
                            vegetal.Preco = (decimal)(dr["preco"]);
                            vegetal.Validade = Convert.ToDateTime(dr["validade"]);

                            vegetais.Add(vegetal);
                        }
                    }
                }
            }
            return vegetais;
        }

        public bool Insert(Models.Vegetais vegetal)
        {
            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    string validadeFormatada = vegetal.Validade.ToString("yyyy-MM-dd");

                    _cmd.CommandText = "insert into vegetais(nome, preco,validade) values (@nome, @preco, @validade); select convert(int, scope_identity());";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = vegetal.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@preco", SqlDbType.Decimal)).Value = vegetal.Preco;
                    _cmd.Parameters.Add(new SqlParameter("@validade", SqlDbType.Date)).Value = validadeFormatada;

                    vegetal.Id = (int)_cmd.ExecuteScalar();
                }
            }
            return vegetal.Id != 0;
        }

        public bool Update(Models.Vegetais vegetal)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    string validadeFormatada = vegetal.Validade.ToString("yyyy-MM-dd");

                    _cmd.CommandText = $"update vegetais set nome = @nome, preco = @preco, validade = @validade where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = vegetal.Id;
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = vegetal.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@preco", SqlDbType.Decimal)).Value = vegetal.Preco;
                    _cmd.Parameters.Add(new SqlParameter("@validade", SqlDbType.DateTime)).Value = validadeFormatada;

                    linhasAfetadas = _cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas != 0;
        }

        public bool DeleteById(int id)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                _conn.Open();

                using (_cmd)
                {
                    _cmd.CommandText = $"delete from vegetais where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = _cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas == 1;
        }
    }
}
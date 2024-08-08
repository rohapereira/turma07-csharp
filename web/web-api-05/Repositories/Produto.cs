using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace web_api_05.Repositories
{
    public class Produto
    {
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;
        private readonly string cacheKey = "produtoCache";
        private readonly List<Models.Produto> cacheItem;

        public Produto(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _cmd = new SqlCommand
            {
                Connection = _conn
            };
        }

        public async Task<List<Models.Produto>> Select()
        {
            if (cacheItem != null)
            {
                return cacheItem;
            }

            List<Models.Produto> produtos = new List<Models.Produto>();

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT id, nome, estoque, preco FROM produto";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Produto produto = new Models.Produto();

                            produto.Id = (int)dr["id"];
                            produto.Nome = dr["nome"].ToString();
                            produto.Estoque = (int)dr["estoque"];
                            produto.Preco = (decimal)dr["preco"];
                        }
                    }
                }
                Util.Cache.setCache(cacheKey, produtos, 50);
            }
            return produtos;
        }

        public async Task<Models.Produto> SelectById(int id)
        {
            Models.Produto produto = null;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, estoque, preco from produto where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            produto = new Models.Produto();

                            produto.Id = (int)dr["id"];
                            produto.Nome = dr["nome"].ToString();
                            produto.Estoque = (int)dr["estoque"];
                            produto.Preco = (decimal)dr["preco"];
                        }
                    }
                }
            }
            return produto;
        }

        public async Task<List<Models.Produto>> GetByName(string nome)
        {
            List<Models.Produto> produtos = new List<Models.Produto>();

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, nome, estoque, preco from produto where nome like @nome;";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = $"%{nome}%";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Produto produto = new Models.Produto();

                            produto.Id = (int)dr["id"];
                            produto.Nome = dr["nome"].ToString();
                            produto.Estoque = (int)dr["estoque"];
                            produto.Preco = (decimal)dr["preco"];

                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

        public async Task<bool> Add(Models.Produto produto)
        {
            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "insert into produto (nome,estoque, preco) values (@nome,@estoque,@preco);select convert(int,SCOPE_IDENTITY()) as id";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = produto.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@estoque", SqlDbType.Int)).Value = produto.Estoque;
                    _cmd.Parameters.Add(new SqlParameter("@preco", SqlDbType.Decimal)).Value = produto.Preco;

                    produto.Id = (int)await _cmd.ExecuteScalarAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return produto.Id != 0 ? true : false;
        }

        public async Task<bool> Update(Models.Produto produto)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "update produto set nome = @nome, estoque = @estoque, preco = @preco where id = @id;";

                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = produto.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@estoque", SqlDbType.Int)).Value = produto.Estoque;
                    _cmd.Parameters.Add(new SqlParameter("@preco", SqlDbType.Decimal)).Value = produto.Preco;

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
                    _cmd.CommandText = "delete from produto where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas == 1;
        }
    }
}
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace web_api.Repositories.SQLServer
{
    public class Medico
    {
        // Atributo
        private readonly SqlConnection _conn;
        private readonly SqlCommand _cmd;
        private readonly string cacheKey = "medicoCache";
        private readonly List<Models.Medico> cacheItem;
        //private static readonly ObjectCache Cache = MemoryCache.Default;
        //private const string CacheKey = "MedicosCache";
        //private const int CacheExpirationInMinutes = 10;

        public Medico(string connectionString)
        {
            _conn = new SqlConnection(connectionString); // prepara a conexão para ser utilizada
            _cmd = new SqlCommand(); // Cria o Objeto Command para fazer as requisições no banco de dados
            _cmd.Connection = _conn; // Mostra o caminho que o command tem que fazer para enviar a mensagem
        }

        public async Task<List<Models.Medico>> GetAll()
        {
            if (cacheItem != null)
            {
                return cacheItem;
            }

            // Verifica se os dados estão no cache
            //if (Cache.Contains(CacheKey))
            //{
            //    return (List<Models.Medico>)Cache.Get(CacheKey);
            //}
            List<Models.Medico> medicos = new List<Models.Medico>(); // Instancia de um lista do tipo medico

            using (_conn)
            {
                await _conn.OpenAsync(); // Abre a conexão

                using (_cmd)
                {
                    _cmd.CommandText = "SELECT id, crm, nome FROM medico order by id"; // Mostra para o command a instrução sql que terá de ser executado na base de dados

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync()) // Manda o command executar as ações de conexão e instrução acima e retorna uma tabela como resposta do banco de dados
                    {
                        while (await dr.ReadAsync()) // Função para ler a linha seguinte a do cabeçalho da tabela de retorno
                        {
                            Models.Medico medico = new Models.Medico(); // Instancia de um objeto

                            medico.Id = (int)dr["id"]; // atribui o retorno da coluna id dentro do atributo id do médico
                            medico.CRM = dr["crm"].ToString(); // atribui o retorno da coluna CRM dentro do atributo CRM do médito
                            medico.Nome = dr["nome"].ToString(); // atribui o retorno da coluna Nome dentro do atributo Nome do médico

                            medicos.Add(medico); // adiciona o objeto médico dentro de uma lista de médicos
                        }
                    }
                }
                Util.Cache.setCache(cacheKey, medicos, 50);
            }
            // Armazena os dados no cache
            //Cache.Set(CacheKey, medicos, DateTimeOffset.Now.AddMinutes(CacheExpirationInMinutes));

            //return medicos; // retorna o objeto médico
            return medicos; // retorna o objeto medico
        }

        public async Task<Models.Medico> GetById(int id)
        {
            Models.Medico medico = null;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, crm, nome from medico where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            medico = new Models.Medico();

                            medico.Id = (int)dr["id"];
                            medico.CRM = dr["crm"].ToString();
                            medico.Nome = dr["nome"].ToString();
                        }
                    }
                }
            }

            return medico;
        }

        public async Task<Models.Medico> GetByCRM(string crm)
        {
            Models.Medico medico = null;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, crm, nome from medico where crm = @crm;";
                    _cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = crm;

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            medico = new Models.Medico();

                            medico.Id = (int)dr["id"];
                            medico.CRM = dr["crm"].ToString();
                            medico.Nome = dr["nome"].ToString();
                        }
                    }
                }
            }

            return medico;
        }

        public async Task<List<Models.Medico>> GetByName(string nome)
        {
            List<Models.Medico> medicos = new List<Models.Medico>();

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "select id, crm, nome from medico where nome like @nome;";
                    _cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = $"%{nome}%";

                    using (SqlDataReader dr = await _cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Models.Medico medico = new Models.Medico();

                            medico.Id = (int)dr["id"];
                            medico.CRM = dr["crm"].ToString();
                            medico.Nome = (string)dr["nome"];

                            medicos.Add(medico);
                        }
                    }
                }
            }
            return medicos;
        }

        public async Task<bool> Add(Models.Medico medico)
        {

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "insert into medico(crm, nome) values(@crm, @nome); select convert(int,SCOPE_IDENTITY()) as id";
                    _cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.CRM;
                    _cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome;

                    medico.Id = (int)await _cmd.ExecuteScalarAsync();
                }
            }
            // Ivalidar o cache
            //Cache.Remove(CacheKey);

            //return medico.Id != 0 ? true : false;
            Util.Cache.clearCache(cacheKey);

            return medico.Id != 0;
        }

        public async Task<bool> Update(int id, Models.Medico medico)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "update medico set crm = @crm, nome = @nome where id = @id;";
                    _cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.CRM;
                    _cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome;
                    _cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            //Cache.Remove(CacheKey);
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
                    _cmd.CommandText = "delete from medico where id = @id";
                    _cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            //Cache.Remove(CacheKey);
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas == 1;
        }

        public async Task<bool> DeleteByCRM(string crm)
        {
            int linhasAfetadas = 0;

            using (_conn)
            {
                await _conn.OpenAsync();

                using (_cmd)
                {
                    _cmd.CommandText = "delete from medico where crm = @crm";
                    _cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = crm;

                    linhasAfetadas = await _cmd.ExecuteNonQueryAsync();
                }
            }
            //Cache.Remove(CacheKey);
            Util.Cache.clearCache(cacheKey);
            return linhasAfetadas == 1;
        }
    }
}
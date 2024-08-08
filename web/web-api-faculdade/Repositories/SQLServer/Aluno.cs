using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace web_api_faculdade.Repositories.SQLServer
{
    public class Aluno
    {
        private readonly string connectionString;

        public Aluno(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Models.Aluno> GetAll()
        {
            List<Models.Aluno> alunos = new List<Models.Aluno>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select codigo, nome, curso from aluno;";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Aluno aluno = new Models.Aluno();

                            aluno.Codigo = (int)dr["codigo"];
                            aluno.Nome = (string)dr["nome"];
                            aluno.Curso = (string)dr["curso"];

                            alunos.Add(aluno);
                        }
                    }
                }
            }
            return alunos;
        }

        public Models.Aluno GetById(int id)
        {
            Models.Aluno aluno = null;

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select codigo, nome, curso from aluno where codigo = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            aluno = new Models.Aluno();

                            aluno.Codigo = (int)dr["codigo"];
                            aluno.Nome = (string)dr["nome"];
                            aluno.Curso = (string)dr["curso"];
                        }
                    }
                }
            }
            return aluno;
        }

        public bool Add(Models.Aluno aluno)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into aluno (nome,curso) values (@nome,@curso);select convert(int,SCOPE_IDENTITY()) as codigo";
                    cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = aluno.Nome;
                    cmd.Parameters.Add(new SqlParameter("@curso", SqlDbType.VarChar)).Value = aluno.Curso;
                    aluno.Codigo = (int)cmd.ExecuteScalar();
                }
            }
            return aluno.Codigo != 0 ? true : false;
        }

        public bool Update(Models.Aluno aluno)
        {
            int linhasAfetadas = 0;

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update aluno set nome = @nome, curso = @curso where codigo = @id;";
                    cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = aluno.Nome;
                    cmd.Parameters.Add(new SqlParameter("@curso", SqlDbType.VarChar)).Value = aluno.Curso;
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = aluno.Codigo;

                    linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas != 0;
        }

        public bool DeleteById(int id)
        {
            int linhasAfetadas = 0;

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from aluno where codigo = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas == 1;
        }
    }
}
using System.Web.Http;

namespace web_api_faculdade.Controllers
{
    public class AlunosController : ApiController
    {
        public readonly Repositories.SQLServer.Aluno repositorioAluno;

        public AlunosController()
        {
            this.repositorioAluno = new Repositories.SQLServer.Aluno(Configurations.Database.getConnectionString());
        }

        // GET: api/Alunos
        [HttpGet]
        public IHttpActionResult SelectAll()
        {
            return Ok(this.repositorioAluno.GetAll());
        }

        // GET: api/Alunos/5
        [HttpGet]
        public IHttpActionResult SelectById(int id)
        {
            Models.Aluno aluno = this.repositorioAluno.GetById(id);

            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        // POST: api/Alunos
        [HttpPost]
        public IHttpActionResult Insert(Models.Aluno aluno)
        {
            if (!this.repositorioAluno.Add(aluno))
                return InternalServerError();

            return Ok(aluno);
        }

        // PUT: api/Alunos/5
        [HttpPut]
        public IHttpActionResult Update(int id, Models.Aluno aluno)
        {
            if (id != aluno.Codigo)
                return BadRequest("O codigo da requisição não coincide com o Codigo do aluno.");

            if (!this.repositorioAluno.Update(aluno))
                return InternalServerError();

            return Ok(aluno);
        }

        // DELETE: api/Alunos/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!this.repositorioAluno.DeleteById(id))
                return NotFound();

            return Ok();
        }
    }
}

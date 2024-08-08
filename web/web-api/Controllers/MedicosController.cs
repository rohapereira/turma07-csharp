using System.Web.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace web_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MedicosController : ApiController
    {
        // Atributo do Obejto MedicosContoller
        private readonly Repositories.SQLServer.Medico repoMedico;

        // Método construtor do controlador
        public MedicosController()
        {
            this.repoMedico = new Repositories.SQLServer.Medico(Configurations.Database.getConnectionString()); // Instancia do repositorioMedico dentro do MedicosController
        }

        // GET: api/Medicos
        [HttpGet] // Notação do tipo de requisição que o método abaixo vai enxergar
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                return Ok(await this.repoMedico.GetAll()); // Chama o método GetAll dentro do repositorioMedico
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Medicos/5
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Models.Medico medico = await this.repoMedico.GetById(id);//chama o método GetById dentro do repositorioMedico
                if (medico == null)
                    return NotFound();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Medicos?crm=123
        [HttpGet]
        public async Task<IHttpActionResult> Get(string crm)
        {
            try
            {
                Models.Medico medico = await this.repoMedico.GetByCRM(crm); // chama o método GetByCRM dentro do repositorioMedico

                if (medico == null)
                    return NotFound();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetByName(string nome)
        {
            try
            {
                if (nome.Length < 3)
                    return BadRequest("O nome deve ter no mínimo 3 caracteres");

                return Ok(await this.repoMedico.GetByName(nome));
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // POST: api/Medicos
        [HttpPost]
        public async Task<IHttpActionResult> Post(Models.Medico medico)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (!await this.repoMedico.Add(medico))
                    return InternalServerError();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // PUT: api/Medicos/5
        [HttpPut]
        public async Task<IHttpActionResult> Put(int id, Models.Medico medico)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (id != medico.Id)
                    return BadRequest("O id da requisição não coincide com o Id do medico.");

                if (!await this.repoMedico.Update(id, medico))
                    return InternalServerError();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // DELETE: api/Medicos/5
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                if (!await this.repoMedico.DeleteById(id))
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(string crm)
        {
            try
            {
                if (!await this.repoMedico.DeleteByCRM(crm))
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }
    }
}

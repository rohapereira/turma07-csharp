using System.Web.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace web_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PacientesController : ApiController
    {
        public readonly Repositories.SQLServer.Paciente repositorioPaciente;

        public PacientesController()
        {
            this.repositorioPaciente = new Repositories.SQLServer.Paciente(Configurations.Database.getConnectionString());
        }

        // GET: api/Pacientes
        [HttpGet]
        public async Task<IHttpActionResult> SelectAll()
        {
            try
            {
                return Ok(await this.repositorioPaciente.GetAll());
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Pacientes/5
        [HttpGet]
        public async Task<IHttpActionResult> SelectById(int id)
        {
            try
            {
                Models.Paciente paciente = await this.repositorioPaciente.GetById(id);

                if (paciente == null)
                    return NotFound();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // POST: api/Pacientes
        [HttpPost]
        public async Task<IHttpActionResult> Insert(Models.Paciente paciente)
        {
            try
            {
                if (!await this.repositorioPaciente.Add(paciente))
                    return InternalServerError();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // PUT: api/Pacientes/5
        [HttpPut]
        public async Task<IHttpActionResult> Update(int id, Models.Paciente paciente)
        {
            try
            {
                if (id != paciente.Codigo)
                    return BadRequest("O codigo da requisição não coincide com o Codigo do paciente.");

                if (!await this.repositorioPaciente.Update(paciente))
                    return InternalServerError();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // DELETE: api/Pacientes/5
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                if (!await this.repositorioPaciente.DeleteById(id))
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

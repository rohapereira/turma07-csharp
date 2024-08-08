using System.Web.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace web_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MedicamentosController : ApiController
    {
        private readonly Repositories.SQLServer.Medicamento _repositorioMedicamento;

        public MedicamentosController()
        {
            _repositorioMedicamento = new Repositories.SQLServer.Medicamento(Configurations.Database.getConnectionString());
        }

        // GET: api/Medicamentos
        [HttpGet] // Notação
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                return Ok(await _repositorioMedicamento.Select());
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Medicamentos/5
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Models.Medicamento medicamento = await _repositorioMedicamento.SelectById(id);

                if (medicamento == null)
                    return NotFound();

                return Ok(medicamento);
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

                return Ok(await _repositorioMedicamento.GetByName(nome));
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // POST: api/Medicamentos
        [HttpPost]
        public async Task<IHttpActionResult> Post(Models.Medicamento medicamento)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (medicamento.DataDeFabricacao > medicamento.DataDeVencimento)
                    return BadRequest("Data de vencimento não pode ser inferior a data de fabricação.");

                if (!await _repositorioMedicamento.Add(medicamento))
                    return InternalServerError();

                return Ok(medicamento);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // PUT: api/Medicamentos/5
        [HttpPut]
        public async Task<IHttpActionResult> Put(int id, Models.Medicamento medicamento)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (id != medicamento.Id)
                    return BadRequest("O id da requisição não coincide com o Id do medicamento.");

                if (medicamento.DataDeFabricacao > medicamento.DataDeVencimento)
                    return BadRequest("Data de vencimento não pode ser inferior a data de fabricação.");

                if (!await _repositorioMedicamento.Update(medicamento))
                    return NotFound();

                return Ok(medicamento);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // DELETE: api/Medicamentos/5
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                if (!await _repositorioMedicamento.DeleteById(id))
                    return NotFound();

                return Ok("Medicamento excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }
    }
}

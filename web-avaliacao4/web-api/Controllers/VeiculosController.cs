using System;
using System.Web.Http;

namespace web_api.Controllers
{
    public class VeiculosController : ApiController
    {
        private readonly Repositories.SQLServer.Veiculo _repositorioVeiculo;

        public VeiculosController()
        {
            _repositorioVeiculo = new Repositories.SQLServer.Veiculo(Configurations.Database.getConnectionString());
        }

        // GET: api/Veiculos
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_repositorioVeiculo.SelectAll());
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Veiculos/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Models.Veiculo veiculo = _repositorioVeiculo.SelectById(id);
                if (veiculo == null)
                    return NotFound();

                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Veiculos/Nome=Exemplo
        [HttpGet]
        public IHttpActionResult Get(string Nome)
        {
            try
            {
                if (Nome.Length < 3)
                    return BadRequest("O nome deve ter no mínimo 3 caracteres");

                return Ok(_repositorioVeiculo.SelectByName(Nome));
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // POST: api/Veiculos
        [HttpPost]
        public IHttpActionResult Post(Models.Veiculo veiculo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (!_repositorioVeiculo.Add(veiculo))
                    return InternalServerError();

                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);
                return InternalServerError();
            }
        }

        // PUT: api/Veiculos/5
        [HttpPut]
        public IHttpActionResult Put(int id, Models.Veiculo veiculo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != veiculo.Id)
                    return BadRequest("O id da requisição não coincide com o Id do veículo.");

                if (!_repositorioVeiculo.Update(id, veiculo))
                    return InternalServerError();

                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);
                return InternalServerError();
            }
        }

        // DELETE: api/Veiculos/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (!_repositorioVeiculo.Delete(id))
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

using System.Web.Http;
using System;
using System.Web.Http.Cors;

namespace Revisao_Backend.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class VegetaisController : ApiController
    {
        private readonly Repositories.Vegetais repositorioVegetais;

        public VegetaisController()
        {
            this.repositorioVegetais = new Repositories.Vegetais(Configurations.Database.getConnectionString());
        }

        // GET: api/Vegetais
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(this.repositorioVegetais.Select());
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Vegetais/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Models.Vegetais vegetal = this.repositorioVegetais.SelectById(id);
                if(vegetal == null)
                {
                    return NotFound();
                }

                return Ok(vegetal);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Get(string nome)
        {
            if (nome.Length < 3)
                return BadRequest("O nome deve conter no mínimo 3 caracteres");

            return Ok(this.repositorioVegetais.SelectByName(nome));
        }

        // POST: api/Vegetais
        public IHttpActionResult Post([FromBody]Models.Vegetais vegetal)
        {
            try
            {
                if (!this.repositorioVegetais.Insert(vegetal))
                    return InternalServerError();

                return Ok(vegetal);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex); 
            }
        }

        // PUT: api/Vegetais/5
        public IHttpActionResult Put(int id, [FromBody]Models.Vegetais vegetal)
        {
            if (id != vegetal.Id)
                return BadRequest("O id da requisição não coincide com o id do vegetal");

            if (!this.repositorioVegetais.Update(vegetal))
                return InternalServerError();

            return Ok(vegetal);
        }

        // DELETE: api/Vegetais/5
        public IHttpActionResult Delete(int id)
        {
            if (!this.repositorioVegetais.DeleteById(id))
                return NotFound();

            return Ok();
        }
    }
}
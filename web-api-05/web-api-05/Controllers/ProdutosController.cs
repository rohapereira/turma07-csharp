using System.Web.Http;
using System;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace web_api_05.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProdutosController : ApiController
    {
        private readonly Repositories.Produto _repositorioProduto;

        public ProdutosController()
        {
            _repositorioProduto = new Repositories.Produto(Configurations.Database.getConnectionString());
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                return Ok(await _repositorioProduto.Select());
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // GET: api/Produtos/5
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Models.Produto produto = await _repositorioProduto.SelectById(id);

                if (produto == null)
                    return NotFound();

                return Ok(produto);
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

                return Ok(await _repositorioProduto.GetByName(nome));
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // POST: api/Produtos
        [HttpPost]
        public async Task<IHttpActionResult> Post(Models.Produto produto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (!await _repositorioProduto.Add(produto))
                    return InternalServerError();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // PUT: api/Produtos/5
        [HttpPut]
        public async Task<IHttpActionResult> Put(int id, Models.Produto produto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (id != produto.Id)
                    return BadRequest("O id da requisição não coincide com o Id do produto.");

                if (!await _repositorioProduto.Update(produto))
                    return NotFound();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }

        // DELETE: api/Produtos/5
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                if (!await _repositorioProduto.DeleteById(id))
                    return NotFound();

                return Ok("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Util.Logger.WriteException(Configurations.Logger.getFullPath(), ex);

                return InternalServerError();
            }
        }
    }
}

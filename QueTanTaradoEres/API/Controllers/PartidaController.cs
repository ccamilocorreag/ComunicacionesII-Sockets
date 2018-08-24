using Comunes.Dto;
using Controlador.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers 
{
    public class PartidaController : ApiController
    {
        IPartidaServicio _partidaServicio;

        public PartidaController(IPartidaServicio partidaServicio)
        {
            _partidaServicio = partidaServicio;
        }

        // GET api/values
        public IEnumerable<PartidaDto> Get()
        {
            return null;
        }

        // GET api/values/5
        public PartidaDto Get(int id)
        {
            return null;
        }

        // POST api/values
        [Route("api/partidas")]
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody]PartidaDto value)
        {
            var result = await Task.Run(() => _partidaServicio.IniciarPartida(value));
            return Ok(result);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]PartidaDto value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
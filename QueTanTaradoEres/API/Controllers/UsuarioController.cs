using Comunes.Dto;
using Controlador.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class UsuarioController : ApiController
    {

        IUsuarioServicio _usuarioServicio;

        public UsuarioController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        // GET api/values
        public IEnumerable<UsuarioDto> Get()
        {
            return null;
        }

        // GET api/values/5
        public UsuarioDto Get(int id)
        {
            return null;
        }

        // POST api/values
        [Route("api/usuarios")]
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody]UsuarioDto value)
        {
            var result = await Task.Run(() => _usuarioServicio.GuardarUsuario(value));
            return Ok(result);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]UsuarioDto value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
using System.Threading.Tasks;
using Comunes.Dto;
using Controlador.Interfaces;
using Modelo.Interfaces;
using Modelo.Modelo;

namespace Controlador.Implementaciones
{
    public class UsuarioServicio : IUsuarioServicio
    {
        IUsuarioDao _usuarioDao;

        public UsuarioServicio(IUsuarioDao usuarioDao)
        {
            _usuarioDao = usuarioDao;
        }

        public async Task<UsuarioDto> GuardarUsuario(UsuarioDto value)
        {
            var usuario = new USU_Usuarios()
            {
                USU_Apodo = value.USU_Apodo
            };

            var nuevoUsuario = await Task.FromResult(_usuarioDao.GuardarUsuario(usuario));

            if (nuevoUsuario == null) return null;

            return new UsuarioDto()
            {
                USU_Id = nuevoUsuario.USU_Id,
                USU_Apodo = nuevoUsuario.USU_Apodo
            };
        }
    }
}

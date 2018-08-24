using Comunes.Dto;
using Controlador.Interfaces;
using Modelo.Interfaces;
using Modelo.Modelo;

namespace Controlador.Implementaciones
{
    public class PartidaServicio : IPartidaServicio
    {
        IPartidaDao _partidaDao;

        public PartidaServicio(IPartidaDao partidaDao)
        {
            _partidaDao = partidaDao;
        }

        public PartidaDto IniciarPartida(PartidaDto value)
        {
            var partidaAbierta = _partidaDao.ObtenerPartidaAbierta();

            if(partidaAbierta != null)
            {
                var usuarioPartida = new USP_UsuariosPartidas()
                {
                    PAR_Id = partidaAbierta.PAR_Id,
                    USU_Id = value.usuario.USU_Id
                };
            }




            //var nuevoUsuario = await Task.FromResult(_usuarioDao.GuardarUsuario(partida));

            //if (nuevoUsuario == null) return null;

            //return new PartidaDto()
            //{
            //    USU_Id = nuevoUsuario.USU_Id,
            //    USU_Apodo = nuevoUsuario.USU_Apodo
            //};
            return null;
        }
    }
}

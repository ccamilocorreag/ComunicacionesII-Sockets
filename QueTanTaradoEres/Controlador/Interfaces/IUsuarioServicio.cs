using Comunes.Dto;
using System.Threading.Tasks;

namespace Controlador.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<UsuarioDto> GuardarUsuario(UsuarioDto value);
    }
}

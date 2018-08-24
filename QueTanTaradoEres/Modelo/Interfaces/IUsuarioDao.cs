using Comunes.Dto;
using Modelo.Modelo;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IUsuarioDao
    {
        USU_Usuarios GuardarUsuario(USU_Usuarios value);
    }
}

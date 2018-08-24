using Modelo.Interfaces;
using Modelo.Modelo;
using System.Linq;

namespace Modelo.Implementaciones
{
    public class PartidaDao : Persistencia, IPartidaDao
    {
        public PartidaDao(IContextoFactory contextoFactory) : base(contextoFactory)
        {

        }

        public PAR_Partidas ObtenerPartidaAbierta()
        {
            return Contexto.PAR_Partidas.FirstOrDefault(x => !x.PAR_Cerrada);
        }
    }
}

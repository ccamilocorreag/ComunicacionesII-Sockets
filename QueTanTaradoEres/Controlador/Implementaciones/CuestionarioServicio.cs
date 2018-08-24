using Controlador.Interfaces;
using Modelo.Interfaces;

namespace Controlador.Implementaciones
{
    public class CuestionarioServicio : ICuestionarioServicio
    {
        ICuestionarioDao _cuestionarioDao;

        public CuestionarioServicio(ICuestionarioDao cuestionarioDao)
        {
            _cuestionarioDao = cuestionarioDao;
        }
    }
}

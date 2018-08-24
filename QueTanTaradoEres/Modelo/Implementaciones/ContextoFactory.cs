using Modelo.Interfaces;
using Modelo.Modelo;
using System.Data.Common;

namespace Modelo.Implementaciones
{
    public class ContextoFactory : IContextoFactory
    {
        public QueTanTaradoEresEntities CrearContexto(DbConnection conexion)
        {
            return new QueTanTaradoEresEntities();
        }

        public QueTanTaradoEresEntities CrearContextoConConexion(string cadenaCompleta)
        {
            return ConstructorConexion.CrearContextoProgramatico(cadenaCompleta);
        }
    }
}

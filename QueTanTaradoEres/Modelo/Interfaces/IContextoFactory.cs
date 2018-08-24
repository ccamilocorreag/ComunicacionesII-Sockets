using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IContextoFactory
    {
        QueTanTaradoEresEntities CrearContexto(DbConnection conexion);
        QueTanTaradoEresEntities CrearContextoConConexion(string cadenaCompleta);
    }
}

using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ConstructorConexion
    {
        public static string CrearCadenaDeConexion(string cadenaConexionCompleta)
        {
            const string providerName = "System.Data.SqlClient";
            const string metaDataLocal = "res://*/Modelo.ModeloNerd.csdl|res://*/Modelo.ModeloNerd.ssdl|res://*/Modelo.ModeloNerd.msl";

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder(cadenaConexionCompleta);


            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder
            {
                Metadata = metaDataLocal,
                Provider = providerName,
                ProviderConnectionString = sqlBuilder.ConnectionString
            };

            return efBuilder.ConnectionString;
        }


        public static QueTanTaradoEresEntities CrearContextoProgramatico(string cadenaConexionCompleta)
        {
            return new QueTanTaradoEresEntities(CrearCadenaDeConexion(cadenaConexionCompleta));
        }
    }
}

using Modelo.Interfaces;
using Modelo.Modelo;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persistencia
    {

        private readonly IContextoFactory _contextoFactory;
        private QueTanTaradoEresEntities _contexto;

        protected Persistencia(IContextoFactory contextoFactory)
        {
            _contextoFactory = contextoFactory;
        }

        public QueTanTaradoEresEntities Contexto
        {
            get => _contexto ?? (_contexto = _contextoFactory.CrearContextoConConexion(ConfigurationManager.ConnectionStrings["QueTanTaradoEresEntities"].ConnectionString));
            set => _contexto = value;
        }

        public void GuardarCambios()
        {
            try
            {
                Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task GuardarCambiosAsyn()
        {
            await Contexto.SaveChangesAsync();
        }

    }
}

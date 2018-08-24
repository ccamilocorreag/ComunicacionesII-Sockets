using Modelo.Interfaces;
using Modelo.Modelo;
using System;
using System.Linq;

namespace Modelo.Implementaciones
{
    public class UsuarioDao : Persistencia, IUsuarioDao
    {
        public UsuarioDao(IContextoFactory contextoFactory) : base(contextoFactory)
        {

        }

        public USU_Usuarios GuardarUsuario(USU_Usuarios value)
        {
            var usuarioOld = Contexto.USU_Usuarios.FirstOrDefault(x => x.USU_Id == value.USU_Id);
            if (usuarioOld == null)
            {
                Contexto.USU_Usuarios.Add(value);
                GuardarCambios();
            }
            return value;
        }
    }
}
